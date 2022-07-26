<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="style.css" />
    <script src="https://kit.fontawesome.com/037c2ab0a6.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:UpdatePanel ID="up" runat="server">
            <ContentTemplate>
                <div class="custom">
                    <div class="container" style ="width: 336px;">
                        
                        <div class="row latest-process justify-content-end" style ="width: 336px;">
                            <div>
                                <p><asp:Label ID="previousNum1" CssClass="Label" runat="server"></asp:Label><asp:Label ID="previousOp" runat="server"></asp:Label><asp:Label ID="previousNum2" CssClass="Label" runat="server"></asp:Label></p>
                            </div>
                        </div>

                        <div class="row result justify-content-end" style ="width: 336px;">
                            <div class="">
                                <p><asp:Label ID="resultNum1" Text="" Visible="true" CssClass="Label" runat="server"></asp:Label><asp:Label ID="resultOp" runat="server"></asp:Label><asp:Label ID="resultNum2" CssClass="Label" runat="server"></asp:Label></p>
                            </div>

                        </div>

                        <br />

                        <div class="row" style ="width: 336px;">
                            <asp:Button OnClick="Clear_Click" Text="ac" class="numbers op1" runat="server"/>
                            <asp:Button OnClick="Negative_Click"  Text="-/+" class="numbers op1" runat="server"/>
                            <asp:Button OnClick="Mod_Click"  Text="%" class="numbers op1" runat="server"/>
                            <asp:Button OnClick="Divide_Click"  Text="/" class="numbers op2" runat="server"/>
                        </div>

                        <div class="row" style ="width: 336px;">
                            <asp:Button OnClick="Button_Click"  Text="7" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="8" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="9" class="numbers" runat="server"/>
                            <asp:Button OnClick="Multiply_Click"  Text="x" class="numbers op2" runat="server"/>
                        </div>
                        
                        <div class="row" style ="width: 336px;">
                            <asp:Button OnClick="Button_Click"  Text="4" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="5" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="6" class="numbers" runat="server"/>
                            <asp:Button OnClick="Minus_Click"  Text="-" class="numbers op2" runat="server"/>
                        </div>

                        <div class="row" style ="width: 336px;">
                            <asp:Button OnClick="Button_Click"  Text="1" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="2" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="3" class="numbers" runat="server"/>
                            <asp:Button OnClick="Plus_Click"  Text="+" class="numbers op2" runat="server"/>
                        </div>

                        <div class="row" style ="width: 336px;">
                            <asp:Button OnClick="Del_Click"  Text="del" class="numbers" runat="server"/>
                            <asp:Button OnClick="Button_Click"  Text="0" class="numbers" runat="server"/>
                            <asp:Button OnClick="Comma_Click" Text="," class="numbers" runat="server"/>
                            <asp:Button OnClick="Equals_Click"  Text="=" class="numbers op2" runat="server"/>
                        </div>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
