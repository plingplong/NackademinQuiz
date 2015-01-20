﻿using QuizProjekt.Models;
using QuizProjekt.Repository;
using QuizProjekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt.Admin
{
    public partial class CreateQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var quiz = new Test();
            quiz.Name = txtName.Text;
            quiz.Description = txtDescription.Text;
            QuizRepository.AddQuiz(quiz);


            Response.Redirect("AddQuestion.aspx?id=" + quiz.Id );
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //här kan det bli fel.... :/

            // OBS!! nu finns det 2 st "GetTest", en i TestService och en i QuizRepository 
            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var test = new Test();
            test.Name = DdlQuizList.SelectedValue;

            QuizRepository.GetTest(i);

            //DdlQuizList

            Response.Redirect("EditQuiz.aspx?id=" + test.Id);
        }

    }
}