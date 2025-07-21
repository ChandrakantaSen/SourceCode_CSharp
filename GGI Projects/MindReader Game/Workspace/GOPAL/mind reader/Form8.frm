VERSION 5.00
Begin VB.Form Form8 
   Caption         =   "Form8"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form8"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "PLAY AGAIN"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   9120
      TabIndex        =   7
      Top             =   6120
      Width           =   3135
   End
   Begin VB.CommandButton Command1 
      Caption         =   "RESULT"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   4080
      TabIndex        =   6
      Top             =   6120
      Width           =   2055
   End
   Begin VB.TextBox Text3 
      Height          =   1095
      Left            =   10800
      TabIndex        =   5
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox Text2 
      Height          =   975
      Left            =   10800
      TabIndex        =   3
      Top             =   2280
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   975
      Left            =   10800
      TabIndex        =   1
      Top             =   840
      Width           =   1575
   End
   Begin VB.Label Label3 
      Caption         =   "THE SECOND NUMBER YOU THOUGHT:"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   2640
      TabIndex        =   4
      Top             =   3600
      Width           =   6855
   End
   Begin VB.Label Label2 
      Caption         =   "THE NUMBER YOU THOUGHT:"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2640
      TabIndex        =   2
      Top             =   2160
      Width           =   5655
   End
   Begin VB.Label Label1 
      Caption         =   "ENTER THE NUMBER  YOU GOT:"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   2640
      TabIndex        =   0
      Top             =   840
      Width           =   5775
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
For i = 0 To 9
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
Text3.Text = j


End Sub

Private Sub Command2_Click()
Form8.Hide
Form1.Show
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""

End Sub

Private Sub Form_Load()
Form8.BackColor = vbBlue
Label1.BackColor = vbBlue
Label1.ForeColor = vbWhite
Label3.BackColor = vbBlue
Label3.ForeColor = vbWhite
Label2.BackColor = vbBlue
Label2.ForeColor = vbWhite
End Sub
