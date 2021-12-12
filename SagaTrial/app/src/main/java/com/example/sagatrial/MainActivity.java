package com.example.sagatrial;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.graphics.Color;
import android.os.Bundle;

import com.ramotion.paperonboarding.PaperOnboardingFragment;
import com.ramotion.paperonboarding.PaperOnboardingPage;
import com.ramotion.paperonboarding.listeners.PaperOnboardingOnRightOutListener;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private FragmentManager fragmentmanager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        fragmentmanager = getSupportFragmentManager();

        final PaperOnboardingFragment paperOnboardingFragment = PaperOnboardingFragment.newInstance(getDataForOnboaring());

        FragmentTransaction fragmentTransaction = fragmentmanager.beginTransaction();
        fragmentTransaction.add(R.id.fragment_container, paperOnboardingFragment);
        fragmentTransaction.commit();


    }

    private ArrayList<PaperOnboardingPage> getDataForOnboaring() {

        PaperOnboardingPage scr1 = new PaperOnboardingPage("Welcome to Saga!", "Your virtual aid to ease your college selection dilemma.",
                Color.parseColor("#ffb174"), R.drawable.cap, R.drawable.cap);
        PaperOnboardingPage scr2 = new PaperOnboardingPage("Connect to students everywhere!", "Hear genuine, first-hand experiences and reviews from students all across India to help you decide what's best for you.",
                Color.parseColor("#22eaaa"), R.drawable.reading, R.drawable.reading);
        PaperOnboardingPage scr3 = new PaperOnboardingPage("It's all verified!", "We aim to provide legitimate information verified by the institute itself so you don't have to worry about the genuineness of the information.",
                Color.parseColor("#ee5a5a"), R.drawable.education, R.drawable.education);

        ArrayList<PaperOnboardingPage> elements = new ArrayList<>();
        elements.add(scr1);
        elements.add(scr2);
        elements.add(scr3);
        return elements;


    }




}