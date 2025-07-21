VERSION 5.00
Begin VB.Form Form8 
   Caption         =   "Form8"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form8"
   Picture         =   "Form9.frx":0000
   ScaleHeight     =   12375
   ScaleWidth      =   22800
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox Text3 
      Height          =   1215
      Left            =   12720
      TabIndex        =   5
      Top             =   5040
      Width           =   2775
   End
   Begin VB.TextBox Text2 
      Height          =   1095
      Left            =   12720
      TabIndex        =   4
      Top             =   2880
      Width           =   2775
   End
   Begin VB.TextBox Text1 
      Height          =   1095
      Left            =   12720
      TabIndex        =   3
      Top             =   960
      Width           =   2655
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H0000C0C0&
      Caption         =   "PLAY AGAIN"
      BeginProperty Font 
         Name            =   "MV Boli"
         Size            =   17.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7920
      TabIndex        =   2
      Top             =   7080
      Width           =   3255
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H8000000B&
      Caption         =   "RESULT"
      BeginProperty Font 
         Name            =   "MV Boli"
         Size            =   17.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   4920
      TabIndex        =   1
      Top             =   5160
      Width           =   2895
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "ENTER YOUR FINAL ANSWER WHAT YOU HAVE FINALLY GOT"
      BeginProperty Font 
         Name            =   "MV Boli"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   1440
      TabIndex        =   0
      Top             =   960
      Width           =   10335
   End
End
Attribute VB_Name = "Form8"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Dim s, i, n, r, p, q, j, d As Integer
n = Val(Text1.Text)
For i = 0 To 7
s = n - i
p = s Mod 10
If (p = 5) Then
j = i
d = s
Exit For
End If
Next
r = Int(d / 10)
q = r - 2
Text2.Text = q
If Text2.Text = "0" Then
Text3.Text = "SUNDAY"
End If
If Text2.Text = "1" Then
Text3.Text = "MONDAY"
End If
If Text2.Text = "2" Then
Text3.Text = "TUESDAY"
End If
If Text2.Text = "3" Then
Text3.Text = "WEDNESDAY"
End If
If Text2.Text = "4" Then
Text3.Text = "THURSDAY"
End If
If Text2.Text = "5" Then
Text3.Text = "FRIDAY"
End If
If Text2.Text = "6" Then
Text3.Text = "SATURDAY"
End If
If Text2.Text = "7" Then
Text3.Text = "WRONG CHOICE"
End If
End Sub


Private Sub Command2_Click()
Form8.Hide
Form1.Show
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
End Sub

Private Sub Form_Load()
Form8.BackColor = vbYellow
Label1.BackColor = vbWhite
Label1.ForeColor = vbBlack
End Sub

