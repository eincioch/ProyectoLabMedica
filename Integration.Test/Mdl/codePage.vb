''' <summary>
''' This codePage class is reusable code to check if a star printer works with a code page.
''' Please note that some printer firmware versions may not output the code page data correctly.
''' </summary>
Public Class codePage


    Private codePagesSupported() As String = {"Normal", "437", "Katakana", "858", "852", "860", "861", "865", "866", "855", "857", "862", "864", "737", "851", "869", "928", "772", "774", "874", "1252", "1250", "1251", "3840", "3841", "3843", "3844", "3845", "3846", "3847", "3848", "1001", "2001", "3001", "3002", "3011", "3012", "3021", "3041"} 'removed , "Thai 42", "Thai 11", "Thai 13", "Thai 14", "Thai 16", "Thai 17", "Thai 18", "User Setting"

    Public Sub New()
        'constructor
    End Sub

    Public Function getAllCodePages() As String()
        Return codePagesSupported
    End Function

    Public Function checkCodePage(ByVal codePg As String) As Boolean
        For Each codePgSupport As String In codePagesSupported
            If (codePgSupport.ToLower() = codePg.ToLower()) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function getStarIOcodePageCmd(ByVal codePg As String) As String
        ' More information about code pages supported by Star Printers in the Line Mode Spec Manual on page 3-4
        Select Case codePg
            Case "Normal"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H0)
            Case "437"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H1)
            Case "Katakana"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H2)
            Case "858"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4)
            Case "852"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H5)
            Case "860"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H6)
            Case "861"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H7)
            Case "863"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H8)
            Case "865"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H9)
            Case "866"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HA)
            Case "855"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HB)
            Case "857"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HC)
            Case "862"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HD)
            Case "864"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HE)
            Case "737"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&HF)
            Case "851"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H10)
            Case "869"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H11)
            Case "928"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H12)
            Case "772"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H13)
            Case "774"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H14)
            Case "874"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H15)
            Case "1252"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H20)
            Case "1250"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H21)
            Case "1251"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H22)
            Case "3840"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H40)
            Case "3841"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H41)
            Case "3843"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H42)
            Case "3844"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H43)
            Case "3845"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H44)
            Case "3846"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H45)
            Case "3847"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H46)
            Case "3848"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H47)
            Case "1001"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H48)
            Case "2001"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H49)
            Case "3001"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4A)
            Case "3002"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4B)
            Case "3011"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4C)
            Case "3012"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4D)
            Case "3021"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4E)
            Case "3041"
                Return Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4F)
        End Select
        'If nothing was found in the switch statement then return null/nothing
        Return Nothing
    End Function

    Protected Overrides Sub Finalize()
        ' Destructor to free unmanaged resources 
        MyBase.Finalize()
    End Sub
End Class

