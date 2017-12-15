package com.example.janelynncamingue.againvid;

import android.support.v7.app.AppCompatActivity;

import java.util.Locale;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.util.DisplayMetrics;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;
import android.widget.AdapterView.OnItemSelectedListener;
import java.util.ArrayList;
import java.util.Random;
import android.widget.TextView;



public class Start extends Activity {
    Spinner spinnerctrl;
    Button btn;
    Locale myLocale;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_start);


        spinnerctrl = (Spinner) findViewById(R.id.spinner1);
        spinnerctrl.setOnItemSelectedListener(new OnItemSelectedListener() {

            public void onItemSelected(AdapterView<?> parent, View view,
                                       int pos, long id) {

                if (pos == 1) {

                    Toast.makeText(parent.getContext(),
                            "日本語", Toast.LENGTH_SHORT)
                            .show();
                    setLocale("ja");
                } else if (pos == 2) {

                    Toast.makeText(parent.getContext(),
                            "English", Toast.LENGTH_SHORT)
                            .show();
                    setLocale("en");
                } else if (pos == 3) {

                    Toast.makeText(parent.getContext(),
                            "Español", Toast.LENGTH_SHORT)
                            .show();
                    setLocale("es");
                } else if (pos==4){
                    Toast.makeText(parent.getContext(),
                            "한국어", Toast.LENGTH_SHORT)
                            .show();
                    setLocale("ko");
                }

            }

            public void onNothingSelected(AdapterView<?> arg0) {
                // TODO Auto-generated method stub
            }

        });
    }



    public void setLocale(String lang) {

        myLocale = new Locale(lang);
        Resources res = getResources();
        DisplayMetrics dm = res.getDisplayMetrics();
        Configuration conf = res.getConfiguration();
        conf.locale = myLocale;
        res.updateConfiguration(conf, dm);
        Intent refresh = new Intent(this, Start.class);
        startActivity(refresh);
    }
    public void nextPage(View v){
        {
            Intent toMainScreen = new Intent(this,MainActivity.class);
            startActivity(toMainScreen);
        }
    }
    public void toInstructionsP1(View v){
        Intent toP1=new Intent(this, instructionP1.class);
        startActivity(toP1);
    }





}
