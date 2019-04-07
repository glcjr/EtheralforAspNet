<%@ Page Title="Contact" Language="C#" MasterPageFile="~/No-Sidebar.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Twenty.Contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="TopMessage" runat="server">
    <h2>Get In Touch</h2>
						<p>Use the form below to give /dev/null a piece of your mind.</p>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="MainMessage" runat="server">
     <header>
													<form>
										<div class="row gtr-50">
											<div class="col-6 col-12-mobile">
												<input type="text" name="name" placeholder="Name" />
											</div>
											<div class="col-6 col-12-mobile">
												<input type="text" name="email" placeholder="Email" />
											</div>
											<div class="col-12">
												<input type="text" name="subject" placeholder="Subject" />
											</div>
											<div class="col-12">
												<textarea name="message" placeholder="Message" rows="7"></textarea>
											</div>
											<div class="col-12">
												<ul class="buttons">
													<li><input type="submit" class="special" value="Send Message" /></li>
												</ul>
											</div>
										</div>
									</form>
</asp:Content>
