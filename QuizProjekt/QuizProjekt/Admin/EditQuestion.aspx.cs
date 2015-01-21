﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Models;
using QuizProjekt.Repository;
using QuizProjekt.Services;

namespace QuizProjekt.Admin
{
    public partial class EditQuestion : System.Web.UI.Page
    {
        private int _questionId;
        private QuestionService _service = new QuestionService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _questionId = Request.QueryString["Id"].ToInt();

        //    if (!Page.IsPostBack)
        //    {
        //        if (_questionId > 0)
        //        {
        //            var question = _service.GetQuestions(_questionId);
        //            if (question != null)
        //            {

                        
                        

        //            }
        //        }
        //    }
        }

        protected void btnSaveToStart_Click(object sender, EventArgs e)
        {
            var question = new Question
            {
               Id = _questionId,
                Text = txtQuestion.Text
            };
            _service.SaveQuestion(question);

            Response.Redirect("~/Default.aspx");
        }

        protected void btnSaveToAlternative_Click(object sender, EventArgs e)
        {
        //    var Test = new Test
        //    {
        //        Id = _quizId,
        //        Name = txtName.Text,
        //        Description = txtDescription.Text
        //    };
        //    _service.SaveTest(Test);

        //    Response.Redirect("~/Default.aspx");
        }
    }
}