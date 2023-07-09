Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization


Public Class clsComandas
    Public Property Comanda As New Propriedades

    Public Function CriarComanda(Optional strNomeComanda As String = "Comanda") As clsComandas
        Dim newComanda As New clsComandas()
        Try

            newComanda.Comanda.ID = ObterNumeroComanda()
            newComanda.Comanda.STATUS = 1
            newComanda.Comanda.NOME = "" & strNomeComanda & ""
        Catch ex As Exception
        End Try
        Return newComanda
    End Function

    Dim numComanda() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public Function ObterNumeroComanda() As Integer
        Dim codComanda As Integer = 0
        Try
            For index = 0 To numComanda.Length - 1
                If numComanda(index) = 0 Then
                    numComanda(index) = (index + 1)
                    codComanda = numComanda(index)
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
        Return codComanda
    End Function


    Public Sub AddItem(tipo As Object,
                       nome As Object,
                       qtde As Object,
                       preco As Object)
        Dim random As New Random()
        ' Criar uma instância do Produto
        Dim produto As New clsProduto()
        produto.STATUS = 1
        produto.ITEM_ID = random.Next(1, 100)
        produto.NOME = nome
        produto.QTDE = qtde
        produto.PRECO = preco
        produto.PRECO_TOTAL = (CInt(qtde) * CDbl(preco))
        produto.TIPO_PRODUTO = CStr(tipo)
        ' Adicionar o produto à lista de itens
        Comanda.ITENS.Add(produto)
    End Sub


    Public Sub AtualizarStatusComanda(ID As Object, STATUS As Object)
        ' Localizar o item na lista de itens pelo nome
        Dim comanda As Propriedades = ID.Find(Function(i) i.ID = ID)

        ' Verificar se o item foi encontrado
        If comanda IsNot Nothing Then
            ' Atualizar o valor do item
            comanda.STATUS = STATUS
        End If
    End Sub


End Class


Public Class Propriedades
    Public Property ID As New Object
    Public Property STATUS As New Object
    Public Property NOME As New Object
    Public Property ITENS As New List(Of clsProduto)

    Public Sub AtualizarValorItem(ITEM_ID As Object, novoPreco As Object)

        ' Localizar o item na lista de itens pelo nome
        Dim item As clsProduto = ITENS.Find(Function(i) i.ITEM_ID = ITEM_ID)

        ' Verificar se o item foi encontrado
        If item IsNot Nothing Then
            ' Atualizar o valor do item
            item.PRECO = novoPreco
        End If
    End Sub
    Public Sub AtualizarStatusItem(ITEM_ID As Object, status As Object)

        ' Localizar o item na lista de itens pelo nome
        Dim item As clsProduto = ITENS.Find(Function(i) i.ITEM_ID = ITEM_ID)

        ' Verificar se o item foi encontrado
        If item IsNot Nothing Then
            ' Atualizar o valor do item
            item.STATUS = status
        End If
    End Sub
End Class

Public Class clsProduto

    Private intITEM_ID As Integer
    Public Property ITEM_ID() As Integer
        Get
            Return intITEM_ID
        End Get
        Set(ByVal value As Integer)
            If intITEM_ID.ToString.Contains(value.ToString) Then
                intITEM_ID = (value * 99) + 1
            Else
                intITEM_ID = value
            End If
        End Set
    End Property
    Public Property NOME As New Object
    Public Property QTDE As New Object
    Public Property PRECO As New Object
    Public Property STATUS As New Object
    Public Property PRECO_TOTAL As New Object
    Public Property TIPO_PRODUTO As New Object

End Class