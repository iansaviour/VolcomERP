﻿Public Class print_barcode
    Public desc As String = ""
    Public size As String = ""
    Public color As String = ""
    Public code As String = ""
    Public retur_code As String = ""
    Public price As Decimal = 0.0
    Public qty As Integer = 1
    'sample
    Public season As String = ""
    Public year As String = ""
    Public class_ As String = ""

    Function generate_text_sample()
        Dim com_print As System.Text.StringBuilder = New System.Text.StringBuilder
        com_print.AppendLine()
        com_print.AppendLine("<ESC>A")
        com_print.AppendLine("<ESC>P02<ESC>H570<ESC>V0060<ESC>L0200<ESC>S" & season & "  " & class_ & "  " & color & "  " & size)
        com_print.AppendLine("<ESC>P02<ESC>H570<ESC>V0080<ESC>L0200<ESC>S" & desc)
        com_print.AppendLine("<ESC>H590<ESC>V0100<ESC>D202120" & code)
        com_print.AppendLine("<ESC>P02<ESC>H570<ESC>V0240<ESC>L0200<ESC>S" & code)
        com_print.AppendLine("<ESC>Q" & qty.ToString)
        com_print.AppendLine("<ESC>Z")
        Dim output As String = com_print.ToString().Replace("<ESC>", (ChrW(27)).ToString())
        Return output
    End Function
    Function generate_text_sample_zebra()
        Dim com_print As System.Text.StringBuilder = New System.Text.StringBuilder
        com_print.AppendLine()
        com_print.AppendLine("CT~~CD,~CC^~CT~")
        com_print.AppendLine("^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR4,4~SD27^JUS^LRN^CI0^XZ")
        com_print.AppendLine("^XA")
        com_print.AppendLine("^MMT")
        com_print.AppendLine("^PW280")
        com_print.AppendLine("^LL0400")
        com_print.AppendLine("^LS0")
        com_print.AppendLine("^BY2,2,160^FT19,234^B2N,,N,N")
        com_print.AppendLine("^FD0" & code & "8^FS")
        com_print.AppendLine("^FT19,258^A0N,23,24^FH\^FD" & code & "^FS")
        com_print.AppendLine("^FT19,71^A0N,14,14^FH\^FD" & desc & "^FS")
        com_print.AppendLine("^FT19,53^A0N,14,14^FH\^FD" & season & "  " & class_ & "  " & color & "  " & size & "^FS")
        com_print.AppendLine("^PQ" & qty.ToString & ",0,1,Y^XZ")
        Dim output As String = com_print.ToString()
        Return output
    End Function
    Function generate_barcode_sample() ' sato
        Dim send_to_printer As String = ""
        Try
            send_to_printer = generate_text_sample()
        Catch ex As Exception
        End Try
        Return send_to_printer
    End Function
    Function generate_barcode_sample_zebra() 'zebra
        Dim send_to_printer As String = ""
        Try
            send_to_printer = generate_text_sample_zebra()
        Catch ex As Exception
        End Try
        Return send_to_printer
    End Function
End Class