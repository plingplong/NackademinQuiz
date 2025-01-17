﻿using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt.Admin
{
    public partial class AddAlternative : System.Web.UI.Page
    {
        private int _alternativeId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _alternativeId = Request.QueryString["Id"].ToInt();
        }

        protected void btnLaggTill_Click(object sender, EventArgs e)
        {
            var qId = Request.QueryString["id"];

            var i = 0;

            int.TryParse(qId, out i);
            var alternative = new Alternative();
            alternative.Id = _alternativeId;
            alternative.Text = txtAlternative.Text;

            QuizRepository.AddAlternative(alternative, i);


            Response.Redirect("AddAlternative.aspx?id=" + _alternativeId);
        }

        protected void btnAvsluta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

    }
}