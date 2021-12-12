Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text

Public Class GlobalVariables
    Public Shared UserCollegeId As String
    Public Shared UsrName As String
    Public Shared UserId As Integer
    Public Shared UserLevel As String
    Public Shared LoginName As String
    Public Shared loginDate As Date
    Public Shared enFormMode As Integer
    Public Shared strConnString As String = "Server=HP-PC\HPPC;Database=IFMSData;User=sa;Pwd=Mh03@123;"
    Public Shared strServer As String
    Public Shared strDatabase As String
    Public Shared strUser As String
    Public Shared strPswd As String
    Public Enum FormMode
        fmAddData = 0
        fmEditData = 1
        fmSaveData = 2
        fmCancelData = 3
        fmDeleteData = 4
        fmPrint = 5
        fmPreview = 6
        fmView = 7
    End Enum
End Class

Public Class SQLControl
    ' get Server Connection Details

    Public DBConn As New SqlConnection("Server=HP-PC\HPPC;Database=IFMSData;User=sa;Pwd=Mh03@123;")
    Public DBCmd As SqlCommand

    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)
    Public ParamsSql As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public ReturnValue As VariantType
    Public intCtrlEntryNo As Integer
    Public intCtrlErrCode As Integer
    Public strCtrlErrMsg As String
    Public Exception As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBConn = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        ReturnValue = 0
        Exception = ""

        Try
            DBConn.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBConn)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
            If RecordCount > 0 Then
                ReturnValue = Val(DBDT.Rows(0)(0)).ToString()
            Else
                ReturnValue = 0
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try
    End Sub

    Public Sub ExecProcedure(SPName As String)
        ' RESET QUERY STATS
        RecordCount = 0
        intCtrlErrCode = 0
        strCtrlErrMsg = ""
        Exception = ""

        Try
            DBConn.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(SPName, DBConn)
            DBCmd.CommandType = CommandType.StoredProcedure

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            DBCmd.Parameters.Add("@out_ErrCode", SqlDbType.Int, 6).Direction = ParameterDirection.Output
            DBCmd.Parameters.Add("@out_ErrMsg", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)

            DBDA.SelectCommand = DBCmd
            DBDA.Fill(DBDT)
            intCtrlErrCode = DBCmd.Parameters("@out_ErrCode").Value
            strCtrlErrMsg = DBCmd.Parameters("@out_ErrMsg").Value
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecProcedure Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try
    End Sub
    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
    ' ADD PARAMS
    Public Sub AddParamSQL(Name As String, DataType As SqlDbType, Precision As Integer, direction As ParameterDirection, Value As Object)
        Dim NewParam As New SqlParameter(Name, DataType, Precision, Value)
        ParamsSql.Add(NewParam)
    End Sub
    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = True) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
    ' Clear Datatable
    Public Sub ClearDBDT()
        DBDT.Clear()
    End Sub
End Class
