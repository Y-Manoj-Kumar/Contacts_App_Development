using System;
using System.Collections;
using System.Linq;

class AppLogic
{
    static void Main (string[] args)
    {
 
    }

    // Numpad,SearchBar,MenuBar are independent with the main logic 

    void Start() //Here we have two cases 1.RecentTab and 2.App DefaultTab
    {
        if(opens_app_recently)
        {

         /*
         -->The app collects the activity of CurrentTab opened and when you opens the app next time
            it displays that OpenedApp.
         */

         // Here we have 3 cases 

            //CASE-1
            if(currentab == favourite_Tab)
            {
                favourite_Tab();
            } 

            // CASE-2
            else if(currentab == recent_Tab)
            {
                recent_Tab();
            }

            // CASE-3   
            else if(currentab == contacts_Tab)
            {
                contacts_Tab();
            }
        }
        else
        {
            //"Displays appsdefaultTab" which is recent_Tab
        }
    }

    #region favourite_Tab;
    void favourite_Tab()
    {
    /*
                                USAGE AND WORKING OF favourite_Tab(ft)
    -->The main function of ft is to bookmark the important contacts  at a specific place which makes easy
       to access/find the contacts.
    -->You can add[displays sub tab] or remove a bookmark at any time. 
    -->And there is a some suggested[the most frequent contacts] bookmark.
    -->You can make a bookmark by going to profile
    */
        void HowToCreateookmark() // Create another class
        {
            if(clicksOnSearchBar) 
            {
                // opens a new window which diaplays keyboard and suggested contacts
                search_Bar();
            }
            else if(clicksOnNumPad)
            {
                // Displays NumPad
                num_Pad();
            }
            else if(clicksOnProfile)
            {
                //displays an option like call,video call and message
            }
        }
    
    }

    #endregion


    void recent_Tab()
    {

    }

    void contacts_Tab()
    {

    }

    void settings()
    {

    }

    void call_History()
    {

    }

    void help_And_Feedback()
    {

    }

    void search_Bar()//
    {
        // based on the input,it shows the related contacts from the database
        // The input format is int,string,char
        if(inputdata == dataindatabase)
        {
        //It shows the output
        // We can add popup option like  click to bookmark,view contact info....
        }
    }

    void num_Pad()
    {
        if(inputdata == dataindatabase)
        {
        //It shows the result
        // We can add popup option like  click to bookmark,view contact info....
        }


    }

}