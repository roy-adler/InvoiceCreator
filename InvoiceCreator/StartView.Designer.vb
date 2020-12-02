<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartView
		Inherits System.Windows.Forms.Form

		'Form overrides dispose to clean up the component list.
		<System.Diagnostics.DebuggerNonUserCode()> _
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
				Try
						If disposing AndAlso components IsNot Nothing Then
								components.Dispose()
						End If
				Finally
						MyBase.Dispose(disposing)
				End Try
		End Sub

		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
		Me.lblSurname = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblStreet = New System.Windows.Forms.Label()
		Me.lblZipCode = New System.Windows.Forms.Label()
		Me.tbSurname = New System.Windows.Forms.TextBox()
		Me.tbName = New System.Windows.Forms.TextBox()
		Me.tbAddressStreet = New System.Windows.Forms.TextBox()
		Me.tbZipCode = New System.Windows.Forms.TextBox()
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.tbOrgAddressZipCode = New System.Windows.Forms.TextBox()
		Me.tbOrgAddressStreet = New System.Windows.Forms.TextBox()
		Me.tbOrgName = New System.Windows.Forms.TextBox()
		Me.tbOrgSurname = New System.Windows.Forms.TextBox()
		Me.lblOrgAdressZipCode = New System.Windows.Forms.Label()
		Me.lblOrgAdressStreet = New System.Windows.Forms.Label()
		Me.lblOrgName = New System.Windows.Forms.Label()
		Me.lblOrgSurname = New System.Windows.Forms.Label()
		Me.lblFrom = New System.Windows.Forms.Label()
		Me.lblTo = New System.Windows.Forms.Label()
		Me.tbOrganization = New System.Windows.Forms.TextBox()
		Me.lblOrganization = New System.Windows.Forms.Label()
		Me.lblOrgAddressState = New System.Windows.Forms.Label()
		Me.tbOrgAddressState = New System.Windows.Forms.TextBox()
		Me.tbAddressState = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnCreateInvoice = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblSurname
		'
		Me.lblSurname.AutoSize = True
		Me.lblSurname.Location = New System.Drawing.Point(65, 218)
		Me.lblSurname.Name = "lblSurname"
		Me.lblSurname.Size = New System.Drawing.Size(82, 25)
		Me.lblSurname.TabIndex = 0
		Me.lblSurname.Text = "Surname"
		Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(65, 262)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(59, 25)
		Me.lblName.TabIndex = 1
		Me.lblName.Text = "Name"
		'
		'lblStreet
		'
		Me.lblStreet.AutoSize = True
		Me.lblStreet.Location = New System.Drawing.Point(65, 306)
		Me.lblStreet.Name = "lblStreet"
		Me.lblStreet.Size = New System.Drawing.Size(57, 25)
		Me.lblStreet.TabIndex = 2
		Me.lblStreet.Text = "Street"
		'
		'lblZipCode
		'
		Me.lblZipCode.AutoSize = True
		Me.lblZipCode.Location = New System.Drawing.Point(65, 351)
		Me.lblZipCode.Name = "lblZipCode"
		Me.lblZipCode.Size = New System.Drawing.Size(84, 25)
		Me.lblZipCode.TabIndex = 3
		Me.lblZipCode.Text = "Zip Code"
		'
		'tbSurname
		'
		Me.tbSurname.Location = New System.Drawing.Point(167, 218)
		Me.tbSurname.Name = "tbSurname"
		Me.tbSurname.Size = New System.Drawing.Size(253, 31)
		Me.tbSurname.TabIndex = 4
		'
		'tbName
		'
		Me.tbName.Location = New System.Drawing.Point(167, 259)
		Me.tbName.Name = "tbName"
		Me.tbName.Size = New System.Drawing.Size(253, 31)
		Me.tbName.TabIndex = 5
		'
		'tbAddressStreet
		'
		Me.tbAddressStreet.Location = New System.Drawing.Point(167, 303)
		Me.tbAddressStreet.Name = "tbAddressStreet"
		Me.tbAddressStreet.Size = New System.Drawing.Size(253, 31)
		Me.tbAddressStreet.TabIndex = 6
		'
		'tbZipCode
		'
		Me.tbZipCode.Location = New System.Drawing.Point(167, 348)
		Me.tbZipCode.Name = "tbZipCode"
		Me.tbZipCode.Size = New System.Drawing.Size(253, 31)
		Me.tbZipCode.TabIndex = 7
		'
		'btnLoad
		'
		Me.btnLoad.Location = New System.Drawing.Point(187, 38)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(194, 34)
		Me.btnLoad.TabIndex = 8
		Me.btnLoad.Text = "Load Template"
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'tbOrgAddressZipCode
		'
		Me.tbOrgAddressZipCode.Location = New System.Drawing.Point(790, 392)
		Me.tbOrgAddressZipCode.Name = "tbOrgAddressZipCode"
		Me.tbOrgAddressZipCode.Size = New System.Drawing.Size(253, 31)
		Me.tbOrgAddressZipCode.TabIndex = 16
		'
		'tbOrgAddressStreet
		'
		Me.tbOrgAddressStreet.Location = New System.Drawing.Point(790, 348)
		Me.tbOrgAddressStreet.Name = "tbOrgAddressStreet"
		Me.tbOrgAddressStreet.Size = New System.Drawing.Size(253, 31)
		Me.tbOrgAddressStreet.TabIndex = 15
		'
		'tbOrgName
		'
		Me.tbOrgName.Location = New System.Drawing.Point(790, 303)
		Me.tbOrgName.Name = "tbOrgName"
		Me.tbOrgName.Size = New System.Drawing.Size(253, 31)
		Me.tbOrgName.TabIndex = 14
		'
		'tbOrgSurname
		'
		Me.tbOrgSurname.Location = New System.Drawing.Point(790, 262)
		Me.tbOrgSurname.Name = "tbOrgSurname"
		Me.tbOrgSurname.Size = New System.Drawing.Size(253, 31)
		Me.tbOrgSurname.TabIndex = 13
		'
		'lblOrgAdressZipCode
		'
		Me.lblOrgAdressZipCode.AutoSize = True
		Me.lblOrgAdressZipCode.Location = New System.Drawing.Point(653, 395)
		Me.lblOrgAdressZipCode.Name = "lblOrgAdressZipCode"
		Me.lblOrgAdressZipCode.Size = New System.Drawing.Size(84, 25)
		Me.lblOrgAdressZipCode.TabIndex = 12
		Me.lblOrgAdressZipCode.Text = "Zip Code"
		'
		'lblOrgAdressStreet
		'
		Me.lblOrgAdressStreet.AutoSize = True
		Me.lblOrgAdressStreet.Location = New System.Drawing.Point(653, 350)
		Me.lblOrgAdressStreet.Name = "lblOrgAdressStreet"
		Me.lblOrgAdressStreet.Size = New System.Drawing.Size(57, 25)
		Me.lblOrgAdressStreet.TabIndex = 11
		Me.lblOrgAdressStreet.Text = "Street"
		'
		'lblOrgName
		'
		Me.lblOrgName.AutoSize = True
		Me.lblOrgName.Location = New System.Drawing.Point(653, 306)
		Me.lblOrgName.Name = "lblOrgName"
		Me.lblOrgName.Size = New System.Drawing.Size(59, 25)
		Me.lblOrgName.TabIndex = 10
		Me.lblOrgName.Text = "Name"
		'
		'lblOrgSurname
		'
		Me.lblOrgSurname.AutoSize = True
		Me.lblOrgSurname.Location = New System.Drawing.Point(653, 262)
		Me.lblOrgSurname.Name = "lblOrgSurname"
		Me.lblOrgSurname.Size = New System.Drawing.Size(82, 25)
		Me.lblOrgSurname.TabIndex = 9
		Me.lblOrgSurname.Text = "Surname"
		Me.lblOrgSurname.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblFrom
		'
		Me.lblFrom.AutoSize = True
		Me.lblFrom.Location = New System.Drawing.Point(189, 160)
		Me.lblFrom.Name = "lblFrom"
		Me.lblFrom.Size = New System.Drawing.Size(54, 25)
		Me.lblFrom.TabIndex = 17
		Me.lblFrom.Text = "From"
		'
		'lblTo
		'
		Me.lblTo.AutoSize = True
		Me.lblTo.Location = New System.Drawing.Point(828, 160)
		Me.lblTo.Name = "lblTo"
		Me.lblTo.Size = New System.Drawing.Size(30, 25)
		Me.lblTo.TabIndex = 18
		Me.lblTo.Text = "To"
		'
		'tbOrganization
		'
		Me.tbOrganization.Location = New System.Drawing.Point(790, 218)
		Me.tbOrganization.Name = "tbOrganization"
		Me.tbOrganization.Size = New System.Drawing.Size(253, 31)
		Me.tbOrganization.TabIndex = 19
		'
		'lblOrganization
		'
		Me.lblOrganization.AutoSize = True
		Me.lblOrganization.Location = New System.Drawing.Point(653, 221)
		Me.lblOrganization.Name = "lblOrganization"
		Me.lblOrganization.Size = New System.Drawing.Size(114, 25)
		Me.lblOrganization.TabIndex = 20
		Me.lblOrganization.Text = "Organization"
		Me.lblOrganization.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblOrgAddressState
		'
		Me.lblOrgAddressState.AutoSize = True
		Me.lblOrgAddressState.Location = New System.Drawing.Point(653, 435)
		Me.lblOrgAddressState.Name = "lblOrgAddressState"
		Me.lblOrgAddressState.Size = New System.Drawing.Size(51, 25)
		Me.lblOrgAddressState.TabIndex = 21
		Me.lblOrgAddressState.Text = "State"
		'
		'tbOrgAddressState
		'
		Me.tbOrgAddressState.Location = New System.Drawing.Point(790, 435)
		Me.tbOrgAddressState.Name = "tbOrgAddressState"
		Me.tbOrgAddressState.Size = New System.Drawing.Size(253, 31)
		Me.tbOrgAddressState.TabIndex = 22
		'
		'tbAddressState
		'
		Me.tbAddressState.Location = New System.Drawing.Point(167, 395)
		Me.tbAddressState.Name = "tbAddressState"
		Me.tbAddressState.Size = New System.Drawing.Size(253, 31)
		Me.tbAddressState.TabIndex = 24
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(65, 395)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 25)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "State"
		'
		'btnCreateInvoice
		'
		Me.btnCreateInvoice.Location = New System.Drawing.Point(931, 490)
		Me.btnCreateInvoice.Name = "btnCreateInvoice"
		Me.btnCreateInvoice.Size = New System.Drawing.Size(112, 34)
		Me.btnCreateInvoice.TabIndex = 25
		Me.btnCreateInvoice.Text = "Go"
		Me.btnCreateInvoice.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1103, 571)
		Me.Controls.Add(Me.btnCreateInvoice)
		Me.Controls.Add(Me.tbAddressState)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbOrgAddressState)
		Me.Controls.Add(Me.lblOrgAddressState)
		Me.Controls.Add(Me.lblOrganization)
		Me.Controls.Add(Me.tbOrganization)
		Me.Controls.Add(Me.lblTo)
		Me.Controls.Add(Me.lblFrom)
		Me.Controls.Add(Me.tbOrgAddressZipCode)
		Me.Controls.Add(Me.tbOrgAddressStreet)
		Me.Controls.Add(Me.tbOrgName)
		Me.Controls.Add(Me.tbOrgSurname)
		Me.Controls.Add(Me.lblOrgAdressZipCode)
		Me.Controls.Add(Me.lblOrgAdressStreet)
		Me.Controls.Add(Me.lblOrgName)
		Me.Controls.Add(Me.lblOrgSurname)
		Me.Controls.Add(Me.btnLoad)
		Me.Controls.Add(Me.tbZipCode)
		Me.Controls.Add(Me.tbAddressStreet)
		Me.Controls.Add(Me.tbName)
		Me.Controls.Add(Me.tbSurname)
		Me.Controls.Add(Me.lblZipCode)
		Me.Controls.Add(Me.lblStreet)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblSurname)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblSurname As Label
	Friend WithEvents lblName As Label
	Friend WithEvents lblStreet As Label
	Friend WithEvents lblZipCode As Label
	Friend WithEvents tbSurname As TextBox
	Friend WithEvents tbName As TextBox
	Friend WithEvents tbAddressStreet As TextBox
	Friend WithEvents tbZipCode As TextBox
	Friend WithEvents btnLoad As Button
	Friend WithEvents tbOrgAddressZipCode As TextBox
	Friend WithEvents tbOrgAddressStreet As TextBox
	Friend WithEvents tbOrgName As TextBox
	Friend WithEvents tbOrgSurname As TextBox
	Friend WithEvents lblOrgAdressZipCode As Label
	Friend WithEvents lblOrgAdressStreet As Label
	Friend WithEvents lblOrgName As Label
	Friend WithEvents lblOrgSurname As Label
	Friend WithEvents lblFrom As Label
	Friend WithEvents lblTo As Label
	Friend WithEvents tbOrganization As TextBox
	Friend WithEvents lblOrganization As Label
	Friend WithEvents lblOrgAddressState As Label
	Friend WithEvents tbOrgAddressState As TextBox
	Friend WithEvents tbAddressState As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnCreateInvoice As Button
End Class
