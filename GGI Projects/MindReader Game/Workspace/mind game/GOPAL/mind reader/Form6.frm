VERSION 5.00
Begin VB.Form Form6 
   Caption         =   "Form6"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form6"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "NEXT"
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
      Left            =   6480
      TabIndex        =   2
      Top             =   5640
      Width           =   2055
   End
   Begin VB.Label Label2 
      Caption         =   "PICK ANOTHER NUMBER FROM 0 TO 9"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   4440
      TabIndex        =   1
      Top             =   2640
      Width           =   6735
   End
   Begin VB.Label Label1 
      Caption         =   "NOW REMEMBER THE ANSWER"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   4920
      TabIndex        =   0
      Top             =   840
      Width           =   5895
   End
End
Attribute VB_Name = "Form6"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Form6.Hide
Form7.Show
End Sub

Private Sub Form_Load()
Form6.BackColor = vbBlue
Label1.BackColor = vbBlue
Label1.ForeColor = vbWhite
Label2.BackColor = vbBlue
Label2.ForeColor = vbWhite
End Sub
