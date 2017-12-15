package com.example.janelynncamingue.againvid;
import android.content.Intent;

import android.os.Bundle;

import android.support.v7.app.AppCompatActivity;

import android.view.View;

/**
 * Created by Janelynn Camingue on 12/9/2017.
 */

public class instructionP1 extends AppCompatActivity{


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.instructions_act1);
    }
    public void toIn2(View v){


        Intent nextIn2 = new Intent(this,instructionP2.class);
        startActivity(nextIn2);
    }

}







