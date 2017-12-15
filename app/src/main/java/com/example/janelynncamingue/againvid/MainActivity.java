package com.example.janelynncamingue.againvid;

import android.content.Intent;
import android.content.res.Resources;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.FrameLayout;
import android.widget.ProgressBar;
import android.widget.Spinner;
import android.widget.TextView;

import java.util.Arrays;
import java.util.List;
import java.util.Random;
import android.support.annotation.NonNull;
import com.vidyo.VidyoClient.Connector.ConnectorPkg;
import com.vidyo.VidyoClient.Connector.Connector;
import android.Manifest;
import android.content.res.Configuration;
import android.telephony.PhoneNumberUtils;
import android.widget.Button;
import java.util.HashMap;
import java.util.Map;
import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import android.content.ContentResolver;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.net.Uri;
import android.support.v4.content.ContextCompat;
import android.telephony.SmsManager;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import java.util.ArrayList;
// image source from https://openclipart.org/detail/282702/nuclear-family-silhouette-radial-2
public class MainActivity extends AppCompatActivity implements Connector.IConnect {

    ArrayList<String> smsMessagesList = new ArrayList<>();
    ListView messages;
    Button send;
    ArrayAdapter arrayAdapter;
    EditText phone;
    ProgressBar progression;
    TextView tv;
    Spinner categories;

   // String topics= new String[];
    Button nextTopic;
    Button unveil;

   // Resources res = getResources();
    int pos;



public int topicCounter=0;
    private Connector vc;
    private FrameLayout videoFrame;
    public String[] topics;
    private int progressionBarStat=0;

    private static MainActivity inst;

    private static final int READ_SMS_PERMISSIONS_REQUEST = 1;

    public static MainActivity instance() {

        return inst;
    }




    @Override
    public void onStart() {
        super.onStart();
        inst = this;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ConnectorPkg.setApplicationUIContext(this);
        ConnectorPkg.initialize();
        videoFrame = (FrameLayout)findViewById(R.id.videoFrame);


        messages = (ListView) findViewById(R.id.messages);
        unveil=(Button) findViewById(R.id.unveil);
        phone=(EditText) findViewById(R.id.phone);
        input = (EditText) findViewById(R.id.input);
        send=(Button) findViewById(R.id.send);
        arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, smsMessagesList);
        messages.setAdapter(arrayAdapter);
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.READ_SMS)
                != PackageManager.PERMISSION_GRANTED) {
            getPermissionToReadSMS();
        } else {
            refreshSmsInbox();
        }

        progression=(ProgressBar)findViewById(R.id.progression);
        tv = (TextView) findViewById(R.id.tv);
        tv.setText("???");


        categories = (Spinner) findViewById(R.id.categories);
        categories.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            public void onItemSelected(AdapterView<?> parent, View view, int pos, long id) {
               // ImageView imageView = (ImageView) findViewById(R.id.imageViewAttraction);
                Resources res = getResources();
                switch(pos){
                    case 1:

                    Toast.makeText(parent.getContext(),
                            "Animals", Toast.LENGTH_SHORT)
                            .show();
                    topics = res.getStringArray(R.array.animalTopics);

                    break;

                    case 2:
                    Toast.makeText(parent.getContext(),
                            "Family", Toast.LENGTH_SHORT)
                            .show();
                    topics = res.getStringArray(R.array.familyTopics);
                    break;

                    case 3:
                    Toast.makeText(parent.getContext(),
                            "Feeling", Toast.LENGTH_SHORT)
                            .show();
                     topics = res.getStringArray(R.array.feelingTopics);
                     break;

                    case 4:
                    Toast.makeText(parent.getContext(),
                            "Goals", Toast.LENGTH_SHORT)
                            .show();
                    topics = res.getStringArray(R.array.goalTopics);
                    break;
                    case 5:
                    Toast.makeText(parent.getContext(),
                            "Movies", Toast.LENGTH_SHORT)
                            .show();
                    topics = res.getStringArray(R.array.movieTopics);
                    break;
                }
            }
            public void onNothingSelected(AdapterView<?> arg0) {
                // TODO Auto-generated method stub
            }

        });

    }


    public void updateProgression(View v){
        Intent doneWithGame = new Intent(this,Start.class);
            progression.setProgress(progression.getProgress() + 25);
            progressionBarStat += 25;
       // Resources res = getResources();
        //myString = res.getStringArray(R.array.topics);

       // String q = topics[rgenerator.nextInt(myString.length)];

       // Resources res = getResources();

      //  String[] topics = res.getStringArray(R.array.topics);
      //  topics = res.getStringArray(R.array.topics);

       /* String q = topics[topics.length];

        TextView tv = (TextView) findViewById(R.id.tv);
        tv.setText(q);*/
tv.setText(topics[topicCounter]);
        if(topicCounter+1<topics.length-1){
           topicCounter++;
        }else{
            topicCounter=0;
        }
        if(progressionBarStat>=125) {
            startActivity(doneWithGame);
        }

    }
    public void unveilBtn(View v){
        try {
            tv.setText(topics[topicCounter]);
            if (topicCounter <= 1) {
                topicCounter++;
                unveil.setVisibility(View.GONE);
            }
        }catch (Exception e){
            Toast.makeText(MainActivity.this,"Choose a category, first!",Toast.LENGTH_LONG).show();
        }
    }

    // Here is how the players can receive the message as a translated version of the other player's message
    // This uses Google Client Cloud's API
    public void updateInbox(final String smsMessage) {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyCzQOhkLxKlTuLOTqjqbSaQH95OemEuVfI";
        StringRequest stringRequest = new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                try {
                    //Creating JsonObject from response String
                    JSONObject jsonObject = new JSONObject(response.toString());
                    jsonObject = jsonObject.getJSONObject("data");
                    JSONArray test = jsonObject.getJSONArray("translations");
                    jsonObject = test.getJSONObject(0);
                    String msg = jsonObject.getString("translatedText");
                    //extracting json array from response string
                    //JSONArray jsonArray = jsonObject.getJSONArray("data");
                    //JSONObject jsonRow = jsonArray.getJSONObject(0);
                    //get value from jsonRow
                    //String resultStr = jsonRow.getString("translatedText");
                    arrayAdapter.insert(msg, 0);
                    arrayAdapter.notifyDataSetChanged();

                } catch (JSONException e) {

                }

            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

            }
        }) {
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                Map<String, String> parameters = new HashMap<String, String>();
                parameters.put("q", smsMessage);
                Resources res = getResources();
                Configuration conf = res.getConfiguration();
                String lang = conf.locale.toString();
                parameters.put("target",lang);

                return parameters;
            }

        };
        queue.add(stringRequest);
        arrayAdapter.insert(smsMessage, 0);
        arrayAdapter.notifyDataSetChanged();
    }

    EditText input;
    SmsManager smsManager = SmsManager.getDefault();

    public void onSendClick(View view) {
        try {
            EditText text = (EditText) findViewById(R.id.phone);
            String i = PhoneNumberUtils.formatNumber(text.getText().toString());
            if (ContextCompat.checkSelfPermission(this, Manifest.permission.SEND_SMS)
                    != PackageManager.PERMISSION_GRANTED) {
                getPermissionToReadSMS();
            } else {
                smsManager.sendTextMessage(i, null, input.getText().toString(), null, null);
                Toast.makeText(this, "Message sent!", Toast.LENGTH_SHORT).show();
            }
        }catch (Exception e){
            Toast.makeText(MainActivity.this,"Input a message, first!",Toast.LENGTH_LONG).show();
        }
    }


    public void getPermissionToReadSMS() {
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.READ_SMS)
                != PackageManager.PERMISSION_GRANTED) {
            if (shouldShowRequestPermissionRationale(
                    Manifest.permission.READ_SMS)) {
                Toast.makeText(this, "Please allow permission!", Toast.LENGTH_SHORT).show();
            }
            requestPermissions(new String[]{Manifest.permission.READ_SMS},
                    READ_SMS_PERMISSIONS_REQUEST);
        }
    }


    @Override
    public void onRequestPermissionsResult(int requestCode,
                                           @NonNull String permissions[],
                                           @NonNull int[] grantResults) {
        // Make sure it's our original READ_CONTACTS request
        if (requestCode == READ_SMS_PERMISSIONS_REQUEST) {
            if (grantResults.length == 1 &&
                    grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                Toast.makeText(this, "Read SMS permission granted", Toast.LENGTH_SHORT).show();
                refreshSmsInbox();
            } else {
                Toast.makeText(this, "Read SMS permission denied", Toast.LENGTH_SHORT).show();
            }

        } else {
            super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        }



    }

    public void refreshSmsInbox() {
        ContentResolver contentResolver = getContentResolver();
        Cursor smsInboxCursor = contentResolver.query(Uri.parse("content://sms/inbox"), null, null, null, null);
        int indexBody = smsInboxCursor.getColumnIndex("body");
        int indexAddress = smsInboxCursor.getColumnIndex("address");
        if (indexBody < 0 || !smsInboxCursor.moveToFirst()) return;
        arrayAdapter.clear();
    /*    do {
            String str = "SMS From: " + smsInboxCursor.getString(indexAddress) +
                    "\n" + smsInboxCursor.getString(indexBody) + "\n";
            arrayAdapter.add(str);
        } while (smsInboxCursor.moveToNext());
        */
        do {
            String str = smsInboxCursor.getString(indexBody) + "\n";
            arrayAdapter.add(str);
        } while (smsInboxCursor.moveToNext());
//messages.setSelection(arrayAdapter.getCount() - 1);
    }
    public void backToStart(View v){
        {
            arrayAdapter.clear();
            arrayAdapter.notifyDataSetChanged();
            Intent goToStart = new Intent(this,Start.class);
            startActivity(goToStart);

        }
    }
    // Use this when putting guess screen and video screen on the same page
    // Using Vidyo.io API for starting and finishing a connection.
    // I set the max participants to 15, but I can change it to any number.
    // The app generates a token in the backend which allow connection between anyone with the app.

    public void Start(View v) {
        vc = new Connector(videoFrame, Connector.ConnectorViewStyle.VIDYO_CONNECTORVIEWSTYLE_Default, 15, "warning info@VidyoClient info@VidyoConnector", "", 0);
        vc.showViewAt(videoFrame, 0, 0, videoFrame.getWidth(), videoFrame.getHeight());

        String token = "cHJvdmlzaW9uAERlbW9Vc2VyQDliNGVlMS52aWR5by5pbwA2MzcxMTYxNjI1OQAAOWFhMGY4NTk1MGY4Y2Q4YzBhNWZiNDA5N2QyN2E2N2E5OGI0MzJmZDJkNmNlMDQ4ZDM4NTE2ZWFiNTM0ZjM0ZjgwM2RlMzEyNmRiZTMzN2FmNWIzOTIwNzU2ODdlMjEw";
        vc.connect("prod.vidyo.io", token, "DemoUser", "DemoRoom", this);

    }


    public void Disconnect(View v) {
        try {
            vc.disconnect();
        }catch (Exception e){
            Toast.makeText(MainActivity.this,"You must be connected, first!",Toast.LENGTH_LONG).show();
        }
    }



    public void onSuccess() {}

    public void onFailure(Connector.ConnectorFailReason reason) {}

    public void onDisconnected(Connector.ConnectorDisconnectReason reason) {}


/*
    public void showTopic(View v){


        Resources res = getResources();

        myString = res.getStringArray(R.array.topics);

        String q = myString[rgenerator.nextInt(myString.length)];


        TextView tv = (TextView) findViewById(R.id.tv);
        tv.setText(q);
    }

*/


}