﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuizProjekt.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
            <div id="h1">
            <asp:Label runat="server" Text="MM Quizes"></asp:Label>
                </div>
            </div>
            <div id="meny">

                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Logga in" />

            </div>
    <asp:Repeater ID="QuizList" runat="server">
        <ItemTemplate>
            
            <div id="QuizDiv">
                <br />
                <div id="ListQuiz"><a href="DoQuiz.aspx?id=<%#Eval("Id") %>"><%#Eval("Name") %> 
                     </a>
                    <br />
                    <%#Eval("Description") %>
                </div>
            </div>
            
        </ItemTemplate>
    </asp:Repeater>
       
</asp:Content>
