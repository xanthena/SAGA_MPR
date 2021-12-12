package com.example.sagatrial;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageButton;

import com.example.sagatrial.HelperClasses.HomeAdapter.FeaturedAdapter;
import com.example.sagatrial.HelperClasses.HomeAdapter.FeaturedHelperClass;

import java.util.ArrayList;

public class dashboard extends AppCompatActivity {

    RecyclerView featuredRecycler;
    RecyclerView.Adapter adapter;
    ImageButton reviewcall;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_dashboard);

        reviewcall = findViewById(R.id.call_review);
        reviewcall.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(dashboard.this, review.class);
                startActivity(intent);
            }
        });

        featuredRecycler = findViewById(R.id.featured_recycler);
        
        featuredRecycler();
    }

    private void featuredRecycler() {

        featuredRecycler.setHasFixedSize(true);
        featuredRecycler.setLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false));

        ArrayList<FeaturedHelperClass> featuredLocations = new ArrayList<>();

        featuredLocations.add(new FeaturedHelperClass(R.drawable.tsec, "Thadomal Shahani", "Founded in 1983, it is the first and the oldest private engineering institute affiliated with the University of Mumbai."));
        featuredLocations.add(new FeaturedHelperClass(R.drawable.spit, "Sardar Patel", "Sardar Patel Institute of Technology is an autonomous un-aided Research and Engineering Institute affiliated to University of Mumbai."));
        featuredLocations.add(new FeaturedHelperClass(R.drawable.dj, "DJ Sanghvi", "Dwarkadas Jivanlal Sanghvi College of Engineering, also known as D. J. Sanghvi, is an engineering college in Vile Parle, Mumbai."));

        adapter = new FeaturedAdapter(featuredLocations);
        featuredRecycler.setAdapter(adapter);

    }
}