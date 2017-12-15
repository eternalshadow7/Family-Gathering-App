package com.example.janelynncamingue.againvid;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

/**
 * Created by Janelynn Camingue on 12/9/2017.
 */


public class instructionP2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.instructions_act2);
    }
    public void toIn3(View v){


        Intent nextIn2 = new Intent(this,instructionP6.class);
        startActivity(nextIn2);
    }


}