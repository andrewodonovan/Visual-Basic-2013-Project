<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRepNo = New System.Windows.Forms.Label()
        Me.lblProdFam = New System.Windows.Forms.Label()
        Me.lblProdDesc = New System.Windows.Forms.Label()
        Me.lblWarranty = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFault = New System.Windows.Forms.Label()
        Me.txtRepairNo = New System.Windows.Forms.TextBox()
        Me.cmbProdFam = New System.Windows.Forms.ComboBox()
        Me.grpDocket = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeleteRec = New System.Windows.Forms.Button()
        Me.btnEditRec = New System.Windows.Forms.Button()
        Me.btnAddRec = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpPurch = New System.Windows.Forms.DateTimePicker()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.txtAddLn3 = New System.Windows.Forms.TextBox()
        Me.txtAddLn2 = New System.Windows.Forms.TextBox()
        Me.txtAddLn1 = New System.Windows.Forms.TextBox()
        Me.lblPurchDate = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.cmbStaff = New System.Windows.Forms.ComboBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblServedBy = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtbIMEI = New System.Windows.Forms.MaskedTextBox()
        Me.cmbProdName = New System.Windows.Forms.ComboBox()
        Me.lblIMEI = New System.Windows.Forms.Label()
        Me.cmbRepStatus = New System.Windows.Forms.ComboBox()
        Me.cmbFault = New System.Windows.Forms.ComboBox()
        Me.cmbWarranty = New System.Windows.Forms.ComboBox()
        Me.grpDocket.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(504, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apple Repairs Store"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(614, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patrick St, Cork"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(614, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "(021) 123 123"
        '
        'lblRepNo
        '
        Me.lblRepNo.AutoSize = True
        Me.lblRepNo.Location = New System.Drawing.Point(10, 30)
        Me.lblRepNo.Name = "lblRepNo"
        Me.lblRepNo.Size = New System.Drawing.Size(64, 19)
        Me.lblRepNo.TabIndex = 2
        Me.lblRepNo.Text = "Repair No.:"
        '
        'lblProdFam
        '
        Me.lblProdFam.AutoSize = True
        Me.lblProdFam.Location = New System.Drawing.Point(10, 90)
        Me.lblProdFam.Name = "lblProdFam"
        Me.lblProdFam.Size = New System.Drawing.Size(88, 19)
        Me.lblProdFam.TabIndex = 3
        Me.lblProdFam.Text = "Product Family:"
        '
        'lblProdDesc
        '
        Me.lblProdDesc.AutoSize = True
        Me.lblProdDesc.Location = New System.Drawing.Point(10, 150)
        Me.lblProdDesc.Name = "lblProdDesc"
        Me.lblProdDesc.Size = New System.Drawing.Size(113, 19)
        Me.lblProdDesc.TabIndex = 4
        Me.lblProdDesc.Text = "Product Description:"
        '
        'lblWarranty
        '
        Me.lblWarranty.AutoSize = True
        Me.lblWarranty.Location = New System.Drawing.Point(10, 210)
        Me.lblWarranty.Name = "lblWarranty"
        Me.lblWarranty.Size = New System.Drawing.Size(59, 19)
        Me.lblWarranty.TabIndex = 5
        Me.lblWarranty.Text = "Warranty:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(10, 270)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(82, 19)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Repair Status:"
        '
        'lblFault
        '
        Me.lblFault.AutoSize = True
        Me.lblFault.Location = New System.Drawing.Point(10, 330)
        Me.lblFault.Name = "lblFault"
        Me.lblFault.Size = New System.Drawing.Size(64, 19)
        Me.lblFault.TabIndex = 7
        Me.lblFault.Text = "Fault Type:"
        '
        'txtRepairNo
        '
        Me.txtRepairNo.Location = New System.Drawing.Point(165, 21)
        Me.txtRepairNo.Name = "txtRepairNo"
        Me.txtRepairNo.ReadOnly = True
        Me.txtRepairNo.Size = New System.Drawing.Size(215, 28)
        Me.txtRepairNo.TabIndex = 0
        '
        'cmbProdFam
        '
        Me.cmbProdFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdFam.FormattingEnabled = True
        Me.cmbProdFam.Items.AddRange(New Object() {"Macbook", "iMac", "Mac Pro", "Mac Mini", "iPad Pro", "iPad Air", "iPad Mini", "iPhone", "Apple Watch"})
        Me.cmbProdFam.Location = New System.Drawing.Point(165, 84)
        Me.cmbProdFam.Name = "cmbProdFam"
        Me.cmbProdFam.Size = New System.Drawing.Size(215, 27)
        Me.cmbProdFam.TabIndex = 9
        '
        'grpDocket
        '
        Me.grpDocket.Controls.Add(Me.Panel3)
        Me.grpDocket.Controls.Add(Me.Panel2)
        Me.grpDocket.Controls.Add(Me.Panel1)
        Me.grpDocket.Controls.Add(Me.Label3)
        Me.grpDocket.Controls.Add(Me.Label2)
        Me.grpDocket.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDocket.Location = New System.Drawing.Point(20, 116)
        Me.grpDocket.Name = "grpDocket"
        Me.grpDocket.Size = New System.Drawing.Size(1350, 534)
        Me.grpDocket.TabIndex = 1
        Me.grpDocket.TabStop = False
        Me.grpDocket.Text = "Docket"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnDeleteRec)
        Me.Panel3.Controls.Add(Me.btnEditRec)
        Me.Panel3.Controls.Add(Me.btnAddRec)
        Me.Panel3.Location = New System.Drawing.Point(415, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 433)
        Me.Panel3.TabIndex = 29
        '
        'btnDeleteRec
        '
        Me.btnDeleteRec.Location = New System.Drawing.Point(112, 322)
        Me.btnDeleteRec.Name = "btnDeleteRec"
        Me.btnDeleteRec.Size = New System.Drawing.Size(278, 27)
        Me.btnDeleteRec.TabIndex = 2
        Me.btnDeleteRec.Text = "Remove Record"
        Me.btnDeleteRec.UseVisualStyleBackColor = True
        '
        'btnEditRec
        '
        Me.btnEditRec.Location = New System.Drawing.Point(112, 200)
        Me.btnEditRec.Name = "btnEditRec"
        Me.btnEditRec.Size = New System.Drawing.Size(278, 29)
        Me.btnEditRec.TabIndex = 1
        Me.btnEditRec.Text = "Edit Record"
        Me.btnEditRec.UseVisualStyleBackColor = True
        '
        'btnAddRec
        '
        Me.btnAddRec.Location = New System.Drawing.Point(112, 82)
        Me.btnAddRec.Name = "btnAddRec"
        Me.btnAddRec.Size = New System.Drawing.Size(278, 29)
        Me.btnAddRec.TabIndex = 0
        Me.btnAddRec.Text = "Add Record"
        Me.btnAddRec.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dtpPurch)
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.Controls.Add(Me.txtCustName)
        Me.Panel2.Controls.Add(Me.cmbCounty)
        Me.Panel2.Controls.Add(Me.txtAddLn3)
        Me.Panel2.Controls.Add(Me.txtAddLn2)
        Me.Panel2.Controls.Add(Me.txtAddLn1)
        Me.Panel2.Controls.Add(Me.lblPurchDate)
        Me.Panel2.Controls.Add(Me.lblCustName)
        Me.Panel2.Controls.Add(Me.lblCustAddress)
        Me.Panel2.Controls.Add(Me.cmbStaff)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.lblServedBy)
        Me.Panel2.Font = New System.Drawing.Font("Yanone Kaffeesatz Regular", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(941, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 433)
        Me.Panel2.TabIndex = 28
        '
        'dtpPurch
        '
        Me.dtpPurch.Location = New System.Drawing.Point(165, 23)
        Me.dtpPurch.Name = "dtpPurch"
        Me.dtpPurch.Size = New System.Drawing.Size(215, 28)
        Me.dtpPurch.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(165, 262)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(215, 28)
        Me.txtPhone.TabIndex = 13
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(165, 82)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(215, 28)
        Me.txtCustName.TabIndex = 8
        '
        'cmbCounty
        '
        Me.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cmbCounty.Location = New System.Drawing.Point(165, 222)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(215, 27)
        Me.cmbCounty.TabIndex = 12
        '
        'txtAddLn3
        '
        Me.txtAddLn3.Location = New System.Drawing.Point(165, 195)
        Me.txtAddLn3.Name = "txtAddLn3"
        Me.txtAddLn3.Size = New System.Drawing.Size(215, 28)
        Me.txtAddLn3.TabIndex = 11
        '
        'txtAddLn2
        '
        Me.txtAddLn2.Location = New System.Drawing.Point(165, 168)
        Me.txtAddLn2.Name = "txtAddLn2"
        Me.txtAddLn2.Size = New System.Drawing.Size(215, 28)
        Me.txtAddLn2.TabIndex = 10
        '
        'txtAddLn1
        '
        Me.txtAddLn1.Location = New System.Drawing.Point(165, 141)
        Me.txtAddLn1.Name = "txtAddLn1"
        Me.txtAddLn1.Size = New System.Drawing.Size(215, 28)
        Me.txtAddLn1.TabIndex = 9
        '
        'lblPurchDate
        '
        Me.lblPurchDate.AutoSize = True
        Me.lblPurchDate.Location = New System.Drawing.Point(10, 30)
        Me.lblPurchDate.Name = "lblPurchDate"
        Me.lblPurchDate.Size = New System.Drawing.Size(85, 19)
        Me.lblPurchDate.TabIndex = 15
        Me.lblPurchDate.Text = "Purchase Date:"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(10, 90)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(95, 19)
        Me.lblCustName.TabIndex = 16
        Me.lblCustName.Text = "Customer Name:"
        '
        'lblCustAddress
        '
        Me.lblCustAddress.AutoSize = True
        Me.lblCustAddress.Location = New System.Drawing.Point(10, 150)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.Size = New System.Drawing.Size(105, 19)
        Me.lblCustAddress.TabIndex = 17
        Me.lblCustAddress.Text = "Customer Address"
        '
        'cmbStaff
        '
        Me.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaff.FormattingEnabled = True
        Me.cmbStaff.Items.AddRange(New Object() {"Johnny Pa"})
        Me.cmbStaff.Location = New System.Drawing.Point(165, 322)
        Me.cmbStaff.Name = "cmbStaff"
        Me.cmbStaff.Size = New System.Drawing.Size(215, 27)
        Me.cmbStaff.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(10, 270)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(42, 19)
        Me.lblPhone.TabIndex = 19
        Me.lblPhone.Text = "Phone:"
        '
        'lblServedBy
        '
        Me.lblServedBy.AutoSize = True
        Me.lblServedBy.Location = New System.Drawing.Point(10, 330)
        Me.lblServedBy.Name = "lblServedBy"
        Me.lblServedBy.Size = New System.Drawing.Size(62, 19)
        Me.lblServedBy.TabIndex = 20
        Me.lblServedBy.Text = "Served By:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel1.Controls.Add(Me.mtbIMEI)
        Me.Panel1.Controls.Add(Me.cmbProdName)
        Me.Panel1.Controls.Add(Me.lblIMEI)
        Me.Panel1.Controls.Add(Me.lblRepNo)
        Me.Panel1.Controls.Add(Me.lblProdFam)
        Me.Panel1.Controls.Add(Me.lblProdDesc)
        Me.Panel1.Controls.Add(Me.lblWarranty)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.lblFault)
        Me.Panel1.Controls.Add(Me.txtRepairNo)
        Me.Panel1.Controls.Add(Me.cmbProdFam)
        Me.Panel1.Controls.Add(Me.cmbRepStatus)
        Me.Panel1.Controls.Add(Me.cmbFault)
        Me.Panel1.Controls.Add(Me.cmbWarranty)
        Me.Panel1.Font = New System.Drawing.Font("Yanone Kaffeesatz Regular", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 433)
        Me.Panel1.TabIndex = 27
        '
        'mtbIMEI
        '
        Me.mtbIMEI.Location = New System.Drawing.Point(165, 381)
        Me.mtbIMEI.Mask = "000000000000000"
        Me.mtbIMEI.Name = "mtbIMEI"
        Me.mtbIMEI.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbIMEI.Size = New System.Drawing.Size(215, 28)
        Me.mtbIMEI.TabIndex = 6
        '
        'cmbProdName
        '
        Me.cmbProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdName.FormattingEnabled = True
        Me.cmbProdName.Location = New System.Drawing.Point(165, 142)
        Me.cmbProdName.Name = "cmbProdName"
        Me.cmbProdName.Size = New System.Drawing.Size(215, 27)
        Me.cmbProdName.TabIndex = 1
        '
        'lblIMEI
        '
        Me.lblIMEI.AutoSize = True
        Me.lblIMEI.Location = New System.Drawing.Point(10, 390)
        Me.lblIMEI.Name = "lblIMEI"
        Me.lblIMEI.Size = New System.Drawing.Size(76, 19)
        Me.lblIMEI.TabIndex = 15
        Me.lblIMEI.Text = "IMEI Number:"
        '
        'cmbRepStatus
        '
        Me.cmbRepStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepStatus.FormattingEnabled = True
        Me.cmbRepStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.cmbRepStatus.Location = New System.Drawing.Point(165, 262)
        Me.cmbRepStatus.Name = "cmbRepStatus"
        Me.cmbRepStatus.Size = New System.Drawing.Size(215, 27)
        Me.cmbRepStatus.TabIndex = 4
        '
        'cmbFault
        '
        Me.cmbFault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFault.FormattingEnabled = True
        Me.cmbFault.Items.AddRange(New Object() {"Cracked Screen", "Broken LCD", "Broken Digitizer", "Water Damage", "Damaged Battery"})
        Me.cmbFault.Location = New System.Drawing.Point(165, 322)
        Me.cmbFault.Name = "cmbFault"
        Me.cmbFault.Size = New System.Drawing.Size(215, 27)
        Me.cmbFault.TabIndex = 5
        '
        'cmbWarranty
        '
        Me.cmbWarranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWarranty.FormattingEnabled = True
        Me.cmbWarranty.Items.AddRange(New Object() {"In Warranty", "Out of Warranty"})
        Me.cmbWarranty.Location = New System.Drawing.Point(165, 202)
        Me.cmbWarranty.Name = "cmbWarranty"
        Me.cmbWarranty.Size = New System.Drawing.Size(215, 27)
        Me.cmbWarranty.TabIndex = 3
        '
        'Details
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1382, 653)
        Me.Controls.Add(Me.grpDocket)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.grpDocket.ResumeLayout(False)
        Me.grpDocket.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRepNo As System.Windows.Forms.Label
    Friend WithEvents lblProdFam As System.Windows.Forms.Label
    Friend WithEvents lblProdDesc As System.Windows.Forms.Label
    Friend WithEvents lblWarranty As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblFault As System.Windows.Forms.Label
    Friend WithEvents txtRepairNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbProdFam As System.Windows.Forms.ComboBox
    Friend WithEvents grpDocket As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStaff As System.Windows.Forms.ComboBox
    Friend WithEvents lblServedBy As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblCustAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblPurchDate As System.Windows.Forms.Label
    Friend WithEvents cmbWarranty As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFault As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRepStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtAddLn1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbProdName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCounty As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddLn3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddLn2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblIMEI As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteRec As System.Windows.Forms.Button
    Friend WithEvents btnEditRec As System.Windows.Forms.Button
    Friend WithEvents btnAddRec As System.Windows.Forms.Button
    Friend WithEvents mtbIMEI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpPurch As System.Windows.Forms.DateTimePicker

End Class
