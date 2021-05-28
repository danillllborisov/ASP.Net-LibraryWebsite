using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortfolioWebASP
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(" "))
                {
                    //USer links 
                    LinkButton1.Visible = true; //user login
                    LinkButton2.Visible = true; //sign up

                    LinkButton3.Visible = false; // logout
                    LinkButton7.Visible = false; // username 


                    //Admin links
                    LinkButton6.Visible = true; //admin login

                    LinkButton11.Visible = false; //author management 
                    LinkButton12.Visible = false; //publisher management 
                    LinkButton8.Visible = false; //bookinventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member managemt 
                }
                else if (Session["role"].Equals("user"))
                {
                    //USer links 
                    LinkButton1.Visible = false; //user login
                    LinkButton2.Visible = false; //sign up

                    LinkButton3.Visible = true; // logout
                    LinkButton7.Visible = true; // username 
                    LinkButton7.Text ="Hello " + Session["username"].ToString();

                    //Admin links
                    LinkButton6.Visible = true; //admin login

                    LinkButton11.Visible = false; //author management 
                    LinkButton12.Visible = false; //publisher management 
                    LinkButton8.Visible = false; //bookinventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member managemt
                }
                else if (Session["role"].Equals("admin"))
                {
                    //USer links 
                    LinkButton1.Visible = false; //user login
                    LinkButton2.Visible = false; //sign up

                    LinkButton3.Visible = true; // logout
                    LinkButton7.Visible = true; // username 
                    LinkButton7.Text = "Hello Admin";

                    //Admin links
                    LinkButton6.Visible = false; //admin login

                    LinkButton11.Visible = true; //author management 
                    LinkButton12.Visible = true; //publisher management 
                    LinkButton8.Visible = true; //bookinventory
                    LinkButton9.Visible = true; //book issuing
                    LinkButton10.Visible = true; //member managemt
                }
            }
            catch(Exception ex)
            {
                
            }
            
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthor.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublisher.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookiventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmember.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            //USer links 
            LinkButton1.Visible = true; //user login
            LinkButton2.Visible = true; //sign up

            LinkButton3.Visible = false; // logout
            LinkButton7.Visible = false; // username 


            //Admin links
            LinkButton6.Visible = true; //admin login

            LinkButton11.Visible = false; //author management 
            LinkButton12.Visible = false; //publisher management 
            LinkButton8.Visible = false; //bookinventory
            LinkButton9.Visible = false; //book issuing
            LinkButton10.Visible = false; //member managemt 

            Response.Redirect("homepage.aspx");
        }
    }
}