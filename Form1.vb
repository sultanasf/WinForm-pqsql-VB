Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DataSet1.customers)

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub BindData()
        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=bakery;Uid=postgres;Pwd=tanfi2514;"
        Dim queryString As String = "SELECT * FROM customers"

        Dim connection As New OdbcConnection(connectionString)
        Dim adapter As New OdbcDataAdapter(queryString, connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim streetAddress As String = txtStreetAddress.Text
        Dim city As String = txtCity.Text
        Dim state As String = txtState.Text
        Dim zipCode As String = txtZipCode.Text
        Dim confirm As String = cbConfirm.Text

        If String.IsNullOrEmpty(firstName) Then
            MessageBox.Show("Firstname/lastname tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(lastName) Then
            MessageBox.Show("Firstname/lastname tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Email tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=bakery;Uid=postgres;Pwd=tanfi2514;"
        Dim connection As New OdbcConnection(connectionString)

        Try
            connection.Open()

            ' Create a SQL statement to insert a new row into the database
            Dim sql As String = "INSERT INTO customers (first_name, last_name, email, phone_number, street_address, city, state, zip_code, add_to_mailing_list_) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

            ' Create a command object with the SQL statement and the connection
            Dim command As New OdbcCommand(sql, connection)

            ' Add parameter values to the command object
            command.Parameters.AddWithValue("@first_name", firstName)
            command.Parameters.AddWithValue("@last_name", lastName)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@phone_number", phoneNumber)
            command.Parameters.AddWithValue("@street_address", streetAddress)
            command.Parameters.AddWithValue("@city", city)
            command.Parameters.AddWithValue("@state", state)
            command.Parameters.AddWithValue("@zip_code", zipCode)
            command.Parameters.AddWithValue("@add_to_mailing_list_", confirm)

            ' Execute the command to insert the new row
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            BindData()

            MessageBox.Show(rowsAffected & " row(s) added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting row into the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        cbConfirm.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtStreetAddress.Text = ""
        txtZipCode.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRowId As Integer = CInt(DataGridView1.CurrentRow.Cells(0).Value)

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=bakery;Uid=postgres;Pwd=tanfi2514;"
            Dim queryString As String = "DELETE FROM customers WHERE id = ?"

            Dim connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(queryString, connection)

            command.Parameters.AddWithValue("@id", selectedRowId)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            ' refresh the DataGridView
            BindData()
        End If
    End Sub
End Class
