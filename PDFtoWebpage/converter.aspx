<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="converter.aspx.cs" Inherits="PDFtoWebpage.converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <style>
        .con {
            width: 80%;
            margin: 0px auto;
            margin-top: 10px;
        }

        .jumbotron {
            background-color: #0275d8;
            color: white;
        }

        .con1 {
            width: 30%;
            margin: 0px auto;
            margin-top: 10px;
            margin-top: 20px;
        }

        #ficon
        {
            width: 50px;
            color: white;
        }

        .upload-btn-wrapper {
  position: relative;
  overflow: hidden;
  display: inline-block;
  margin-top: 20px;
}

.btn {
  border: 2px solid gray;
  color: gray;
  background-color: white;
  padding: 8px 20px;
  border-radius: 8px;
  font-size: 20px;
  font-weight: bold;
}

.upload-btn-wrapper input[type=file] {
  font-size: 100px;
  position: absolute;
  left: 0;
  top: 0;
  opacity: 0;
}
.btn1{
    margin-left: 660px;
}
.file{
    margin-left: 30px;
}
    </style>
    <script>

        $(document).ready(function () {
            $('input[type="file"]').change(function (e) {
                var fileName = e.target.files[0].name;
                $("#file").html(fileName);
                

            });
        });


    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container con">
            <div class="jumbotron text-center">
                <h1>PDF To Webpage Converter</h1>
            </div>
        </div>

        <div class="container con1">
            <div class="jumbotron text-center">
                <img id="ficon" src="files.png"/>
                <br />
                <br />

                <asp:FileUpload CssClass="file" ID="fileupload1" runat="server" />
                
            </div>
        </div>

        <asp:Button ID="btnupload" CssClass="btn1 btn-danger btn-lg" OnClick="btnupload_Click" runat="server" Text="Upload" />
         

    </form>

    

   

</body>
</html>
