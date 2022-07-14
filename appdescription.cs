using System;
using System.Collections;
using System.Linq;

class AppLogic
{
    static void Main (string[] args)
    {
 
    }


    void opens_App() //Here we have two cases 1.RecentTab and 2.App DefaultTab
    {
        if(opens_app_recently)
        {

         /*
         -->The app collects the data of last closed tab and when you opens the app next time
           it displays that lastRecentTab.
         */

         // Here we have 3 cases 

            //CASE-1
            if(lastRecentTab == favourite_Tab)
            {
                favourite_Tab();
            } 

            // CASE-2
            else if(lastRecentTab == recent_Tab)
            {
                recent_Tab();
            }

            // CASE-3   
            else if(lastRecentTab == contacts_Tab)
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
    -->You can add[displays sub tab] or remove a contact at any time. 
    -->And there is a some suggested contacts to mark them for bookmark.
    -->You can search the contact in search bar for bookmark  or you can find through numpad 
    */
        void bookmark()
        {
            if(clicksOnSearchBar) 
            {
                // opens a new window which diaplays virtual keyboard and suggested contacts
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