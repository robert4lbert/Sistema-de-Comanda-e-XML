

Imports System.IO
Imports System.Xml.Serialization

Public Class clsXML
    Private Property clsPath As New clsFuncoes

    Public Sub SerializarLista(ByRef lst As List(Of clsComandas))

        ' Create an instance of XmlSerializer for the List(Of Produto)
        Dim serializer As New XmlSerializer(GetType(List(Of clsComandas)))

        ' Specify the file path to save the XML
        Dim filePath As String = clsPath.ObterCaminhoArquivo()

        ' Serialize the Lista to XML
        Using writer As New StreamWriter(filePath)
            serializer.Serialize(writer, lst)
        End Using

    End Sub

    Public Sub AtualizarValorItemLista(Optional intID As Integer = 0,
                                      Optional dblValor As Double = 0)

        Try
            ' Especificar o caminho do arquivo XML
            Dim filePath As String = clsPath.ObterCaminhoArquivo()

            ' Desserializar o XML para uma lista de objetos Produto
            Dim serializer As New XmlSerializer(GetType(List(Of clsComandas)))

            Dim lista As List(Of clsComandas)
            Using reader As New StreamReader(filePath)
                lista = DirectCast(serializer.Deserialize(reader), List(Of clsComandas))
            End Using


            ' Atualizar o valor de um item na lista
            Dim itemToUpdate As clsComandas = lista.Find(Function(p) p.Comanda.ID = intID)
            If itemToUpdate IsNot Nothing Then
                itemToUpdate.Comanda.AtualizarValorItem(intID, dblValor)
            End If

            ' Serializar a lista atualizada de volta para XML
            Using writer As New StreamWriter(filePath)
                serializer.Serialize(writer, lista)
            End Using

        Catch ex As Exception
        End Try
    End Sub

End Class
