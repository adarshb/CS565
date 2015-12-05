<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 622px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            font-size: large;
        }
        .auto-style6 {
            font-size: xx-large;
        }
        .auto-style7 {
            text-align: center;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" colspan="2"><strong><span class="auto-style6">CS565 - Assignment#2</span></strong></td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">Please enter your details</td>
            </tr>
            <tr>
                <td class="auto-style2">Name: </td>
                <td>
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Age: </td>
                <td>
                    <asp:DropDownList ID="Age" runat="server">
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                        <asp:ListItem>32</asp:ListItem>
                        <asp:ListItem>33</asp:ListItem>
                        <asp:ListItem>34</asp:ListItem>
                        <asp:ListItem>35</asp:ListItem>
                        <asp:ListItem>36</asp:ListItem>
                        <asp:ListItem>37</asp:ListItem>
                        <asp:ListItem>38</asp:ListItem>
                        <asp:ListItem>39</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sex: </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Value="Man">Male</asp:ListItem>
                        <asp:ListItem Value="Woman">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Favorite Color: </td>
                <td>
                    <asp:CheckBox ID="Brown" runat="server" Text="Brown" />
                    <asp:CheckBox ID="Black" runat="server" Text="Black" />
                    <asp:CheckBox ID="Green" runat="server" Text="Green" />
                    <asp:CheckBox ID="Blue" runat="server" Text="Blue" />
                    <asp:CheckBox ID="Pink" runat="server" Text="Pink" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Birth:</td>
                <td>
                    <asp:TextBox ID="datetext" runat="server"></asp:TextBox>
                    <asp:Calendar ID="DOB" runat="server" SelectedDate="10/03/2015 11:12:02" VisibleDate="2015-10-03"></asp:Calendar>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Submit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
