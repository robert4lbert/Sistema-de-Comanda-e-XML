Imports System.IO

Public Class clsFuncoes
    Public Name As String = Application.ProductName
    Public xmlFile As String
    Public xmlFolder As String


    Public listaProdutos As New List(Of clsTipoProdutos)()
    Public Function TratarErro(Optional mensagem As String = "")
        Dim msg As String = ""
        Try
            If mensagem <> Nothing AndAlso mensagem <> "" Then
                msg += mensagem
            End If
        Catch ex As Exception

        End Try
        MessageBox.Show(msg)
    End Function
    Public Sub ObterPath()
        Try

            Dim Path As String = ""
            Dim pathLocalUser As String = ""
            pathLocalUser = Application.LocalUserAppDataPath
            Dim pathSplit As String() = pathLocalUser.Split(New Char() {"\"c})
            For index = 0 To pathSplit.Length - 2
                Path += pathSplit(index) & IIf(index < (pathSplit.Length - 2), "\", "")
            Next

            xmlFolder = Path & "\" & Name.ToString.ToUpper
            xmlFile = xmlFolder & "\" & Name.ToString.ToUpper & ".xml"

            If Not Directory.Exists(xmlFolder) Then Directory.CreateDirectory(xmlFolder)

        Catch ex As Exception
        End Try
    End Sub
    Public Function ObterCaminhoArquivo() As String
        If xmlFile = "" Then
            ObterPath()
        End If
        Return xmlFile
    End Function


    '---ConverterListEmGridView
    Public Function PreencherGridView(ByRef lista As List(Of clsComandas),
                                       ByRef gridView As DataGridView)

        Try
            ' Criar o BindingSource e associar a lista de produtos a ele
            Dim bindingSource As New BindingSource()
            Dim listaComandas As List(Of Propriedades) = ObterListaComandas(lista)
            bindingSource.DataSource = listaComandas

            ' Definir o BindingSource como a origem de dados do DataGridView
            gridView.DataSource = bindingSource

        Catch ex As Exception

        End Try
    End Function


    Public Function ObterListaComandas(ByRef lst As List(Of clsComandas)) As List(Of Propriedades)

        Dim listaComandas As New List(Of Propriedades)()

        Try

            ' Exemplo de criação de algumas comandas
            For i As Integer = 0 To lst.Count - 1
                Dim comanda As New Propriedades()
                comanda.ID = lst.Item(i).Comanda.ID
                comanda.NOME = lst.Item(i).Comanda.NOME
                listaComandas.Add(comanda)
            Next

        Catch ex As Exception

        End Try
        Return listaComandas
    End Function

    Public Function PreencherGridViewItem(ByRef lista As List(Of clsComandas),
                                          ByRef gridView As DataGridView)

        Try
            ' Criar o BindingSource e associar a lista de produtos a ele
            Dim bindingSource As New BindingSource()
            Dim listaComandas As List(Of Propriedades) = ObterListaComandas(lista)
            Dim listaComandasItem As List(Of clsProduto) = ObterListaComandasItem(listaComandas)
            bindingSource.DataSource = listaComandasItem

            ' Definir o BindingSource como a origem de dados do DataGridView
            gridView.DataSource = bindingSource

        Catch ex As Exception

        End Try
    End Function

    Public Function ObterListaComandasItem(ByRef lst As List(Of Propriedades)) As List(Of clsProduto)

        Dim listaComandasItem As New List(Of clsProduto)()

        ' Exemplo de criação de algumas comandas
        For i As Integer = 0 To lst.Count - 1
            Dim item As New clsProduto()
            item.ITEM_ID = lst.Item(i).ID
            item.NOME = ""
            listaComandasItem.Add(item)
        Next

        Return listaComandasItem
    End Function

    Public Function ObterProdutos() As List(Of clsTipoProdutos)
        listaProdutos = New List(Of clsTipoProdutos)
        Try
            listaProdutos.Add(New clsTipoProdutos("ARMAZÉM"))
            listaProdutos.Add(New clsTipoProdutos("CALDO"))
            listaProdutos.Add(New clsTipoProdutos("CERVERJA"))
            listaProdutos.Add(New clsTipoProdutos("DIVERSOS"))
            listaProdutos.Add(New clsTipoProdutos("DOSES"))
        Catch ex As Exception
        End Try
        Return listaProdutos
    End Function
End Class


