using System;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace TwigaTest
{

    public partial class Default : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            ResponseCall();
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            //button1.Text = "You clicked me";
            //ResponseCall();
        }

        public void ResponseCall()
        {

            string phone_number = Request.QueryString["phone_number"]; //This is the phone number of the user making the request

            string network = Request.QueryString["network"];  //This is the Mobile Network of the user making the request e.g Mtn, Airtel etc.

            string session_id = Request.QueryString["session_id"];//This is the session id the initiated session. The session id will be maintained for all subsequent session request

            string action = Request.QueryString["action"];  //This can be begin or request. Begin when the session begins and request when the session is to be continued on the customer's request

            string input = Request.QueryString["input"]; //This is the customers input. Empty at begin but with the customer's request at every followed up session

            string all_input = Request.QueryString["all_input"]; //This is a concatenation of all the customer's request since initiated

            //Application Logic: Execute appropriate actions with the information you've extracted
            //and return a reponse in Object Format (containing message and action) as below:
            //if you send "end" as response_action, that means the session is over.

            string message = "";
            string response_action = "";


            var response = new Newtonsoft.Json.Linq.JObject(); //I'm using the Newtonsoft package to build
            //a JSON object here. You can use any method convenient for you, as long as it results in 
            // a JSON Object.

            response.Add("message", message);
            response.Add("action", response_action);

            //returning response 
            Response.Write(response);

        }
    }
}
