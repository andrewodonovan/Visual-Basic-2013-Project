Public Class Details
    Dim intRepNum As Integer = 1 'Sets counter var for repair number

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCounty.SelectedIndex = 0
        cmbProdFam.SelectedIndex = 0
        cmbRepStatus.SelectedIndex = 0
        cmbStaff.SelectedIndex = 0
        cmbWarranty.SelectedIndex = 0
        cmbFault.SelectedIndex = 0
        txtRepairNo.Text = intRepNum
    End Sub




    Private Sub cmbProdFam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdFam.SelectedIndexChanged
        cmbProdName.Items.Add("Choose Other Product Family")
        If cmbProdFam.Text = "Macbook" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("Macbook")
            cmbProdName.Items.Add("Macbook Air")
            cmbProdName.Items.Add("Macbook Pro   13inch Non-Touch")
            cmbProdName.Items.Add("Macbook Pro   13inch Touch ID")
            cmbProdName.Items.Add("Macbook Pro   15inch Touch Bar & Touch ID	")
            cmbProdName.Items.Add("Macbook Pro   15inch Non-Touch")
            cmbProdName.SelectedIndex = 0



        ElseIf cmbProdFam.Text = "iMac" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("21.5inch iMac")
            cmbProdName.Items.Add("21.5inch iMac Retina 4K")
            cmbProdName.Items.Add("21.5inch iMac Retina 5K")
            cmbProdName.SelectedIndex = 0


        ElseIf cmbProdFam.Text = "Mac Pro" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("Mac Pro")
            cmbProdName.SelectedIndex = 0

        ElseIf cmbProdFam.Text = "Mac Mini" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("Mac Mini")
            cmbProdName.SelectedIndex = 0

        ElseIf cmbProdFam.Text = "iPad Pro" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("iPad Pro   9.7inch")
            cmbProdName.Items.Add("iPad Pro   12.9inch")
            cmbProdName.SelectedIndex = 0


        ElseIf cmbProdFam.Text = "iPad Air" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("iPad Air 2   9.7inch")
            cmbProdName.Items.Add("iPad Air     9.7inch")
            cmbProdName.SelectedIndex = 0


        ElseIf cmbProdFam.Text = "iPad Mini" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("iPad Mini 4   7.9inch")
            cmbProdName.Items.Add("iPad Mini 3   7.9inch")
            cmbProdName.Items.Add("iPad Mini 2   7.9inch")
            cmbProdName.Items.Add("iPad Mini 1   7.9inch (Non-Retina)")
            cmbProdName.SelectedIndex = 0


        ElseIf cmbProdFam.Text = "iPhone" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("iPhone 7         4.7inch")
            cmbProdName.Items.Add("iPhone 7 Plus     5.5inch")
            cmbProdName.Items.Add("iPhone 6S        4.7inch")
            cmbProdName.Items.Add("iPhone 6S Plus    5.5inch")
            cmbProdName.Items.Add("iPhone 6         4.7inch")
            cmbProdName.Items.Add("iPhone 6 Plus     5.5inch")
            cmbProdName.Items.Add("iPhone 5S          4inch")
            cmbProdName.Items.Add("iPhone 5C          4inch")
            cmbProdName.Items.Add("iPhone 5           4inch")
            cmbProdName.Items.Add("iPhone SE          4inch")
            cmbProdName.SelectedIndex = 0


        ElseIf cmbProdFam.Text = "Apple Watch" Then
            lblProdFam.Text = "Product Name: "
            cmbProdName.Items.Clear()
            cmbProdName.Items.Add("Apple Watch Series 1")
            cmbProdName.Items.Add("Apple Watch Series 2")
            cmbProdName.SelectedIndex = 0


        Else
            cmbProdName.Text = "Select a Product"
        End If
    End Sub

    Private Sub btnAddRec_Click(sender As Object, e As EventArgs) Handles btnAddRec.Click
       
        txtRepairNo.Text = intRepNum

            Dim RepairsDoc As String = "C:\Users\Andrew\Desktop\College\First Year\Semester 2\Projects\IS1111\RepairsDocument.txt"

            If System.IO.File.Exists(RepairsDoc) = True Then

                Dim sysWrite As New System.IO.StreamWriter(RepairsDoc, True)

1:              sysWrite.Write("==========================================================================================================")
2:              sysWrite.Write(Environment.NewLine)
3:              sysWrite.Write(intRepNum)
4:              sysWrite.Write(Environment.NewLine)
5:              sysWrite.Write("Product Family:  " & cmbProdFam.Text)
6:              sysWrite.Write(Environment.NewLine)
7:              sysWrite.Write("Product Name:  " & cmbProdName.Text)
8:              sysWrite.Write(Environment.NewLine)
9:              sysWrite.Write("Warranty Status:  " & cmbWarranty.Text)
10:             sysWrite.Write(Environment.NewLine)
11:             sysWrite.Write("Fault Type: " & cmbFault.Text)
12:             sysWrite.Write(Environment.NewLine)
13:             sysWrite.Write("IMEI Number: " & mtbIMEI.Text)
14:             sysWrite.Write(Environment.NewLine)
15:             sysWrite.Write("Date of Purchase " & dtpPurch.Value.Date)
16:             sysWrite.Write(Environment.NewLine)
17:             sysWrite.Write("Customer Name  " & txtCustName.Text)
18:             sysWrite.Write(Environment.NewLine)
19:             sysWrite.Write("Customer Address  " & txtAddLn1.Text & ", " & txtAddLn2.Text & ", " & txtAddLn3.Text & ", " & "Co. " & cmbCounty.Text)
20:             sysWrite.Write(Environment.NewLine)
21:             sysWrite.Write("Phone Number:  " & txtPhone.Text)
22:             sysWrite.Write(Environment.NewLine)
23:             sysWrite.Write("Served By:  " & cmbStaff.Text)
24:             sysWrite.Write(Environment.NewLine)
25:             sysWrite.Write("==========================================================================================================")
26:             sysWrite.Write(Environment.NewLine)
                sysWrite.Close()
                MsgBox("The record was added to the archive", MsgBoxStyle.Information, "File Written")

                intRepNum += 1
                txtRepairNo.Text = intRepNum
            Else

                MessageBox.Show("File Does Not Exist. Please check File Path")

            End If
    End Sub

    Private Sub mtbIMEI_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbIMEI.MouseClick
        If mtbIMEI.Text = "" Then
            mtbIMEI.Select(0, 0)
        End If
    End Sub

    Private Sub txtAddLn1_TextChanged(sender As Object, e As EventArgs) Handles txtAddLn1.TextChanged

    End Sub
End Class
