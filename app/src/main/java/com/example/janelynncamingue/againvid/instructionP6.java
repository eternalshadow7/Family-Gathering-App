package com.example.janelynncamingue.againvid;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

/**
 * Created by Janelynn Camingue on 12/10/2017.
 */

public class instructionP6 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.instruction_act6);
    }
    public void toStartScreen(View v){
        Intent goStart = new Intent(this,Start.class);
        startActivity(goStart);
    }
}