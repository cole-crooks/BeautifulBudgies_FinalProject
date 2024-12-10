/*
* Name: Cole Crooks
* email:  crookscl@mail.uc.edu
* Assignment Number: Final Project
* Due Date:   12/10/2024
* Course #/Section:   IS3050-001
* Semester/Year:   Fall 2024
* Brief Description of the assignment:  Final Project for the IS 3050 Web Development w/ .NET

* Brief Description of what this module does. Demonstrating all that we've learned this year, solve one (1) hard leetcode problem per person with class knowledge and Github
* Citations:https://leetcode.com/problems/parsing-a-boolean-expression/description/
            https://github.com/cole-crooks/crookscl_FinalProject          
* Anything else that's relevant: My collaborators on this project are Jack Driehaus (driehajl@mail.uc.edu), Derick Bellofatto (bellofdk@mail.uc.edu), and LAST GUY (HIS EMAIL)
*/

using Leetcode23_MergeKSortedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crookscl_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdProblemSolve_Click(object sender, EventArgs e)
        {
            int selectedIndex = ProblemSelect.SelectedIndex;
            string selectedValue = ProblemSelect.Items[selectedIndex].Value;

            switch (selectedValue)
            {
                case "1":
                    lblSelectedProblemDetails.Text = "<br></br> A boolean expression is an expression that evaluates to either true or false. It can be in one of the following shapes: <br></br> \r\n\r\n't' that evaluates to true. <br></br> \r\n'f' that evaluates to false. <br></br> \r\n'!(subExpr)' that evaluates to the logical NOT of the inner expression subExpr. <br></br> \r\n'&(subExpr1, subExpr2, ..., subExprn)' that evaluates to the logical AND of the inner expressions subExpr1, subExpr2, ..., subExprn where n >= 1. <br></br> \r\n'|(subExpr1, subExpr2, ..., subExprn)' that evaluates to the logical OR of the inner expressions subExpr1, subExpr2, ..., subExprn where n >= 1. <br></br> \r\nGiven a string expression that represents a boolean expression, return the evaluation of that expression. <br></br> \r\n\r\nIt is guaranteed that the given expression is valid and follows the given rules. <br></br> Example 2 Expression: '|(f,f,f,t)'";
                    Problem1106Solution solution = new Problem1106Solution();
                    string expression = "|(f,f,f,t)";
                    bool result = solution.ParseBoolExpr(expression);
                    lblSelectedProblemDetails.Text += "<br></br>Result: " + result.ToString();
                    break;
                case "2":
                    // ... call the method for problem 2
                    break;
                case "3":
                    // ... call the method for Problem 3
                    break;
                case "4":
                    lblSelectedProblemDetails.Text = "Problem 23 has the user combine 3 different arrays, merge them, and sort the numbers smallest to largest. </br>" + "The inputs are L1=[1, 4, 5] L2 =[1, 3, 4] and L3= [2,6] </br>" +"The Solution is as follows: ";
                    lblSelectedProblemDetails.Text += Leetcode23_MergeKSortedLists.Program.Problem23Solution();
                    break;
                default:
                    break;
            }
        }
    }
}