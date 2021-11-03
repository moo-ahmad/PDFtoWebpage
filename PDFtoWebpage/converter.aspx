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
        }

        @import url(https://fonts.googleapis.com/css?family=Open+Sans:700,300);

        .frame {
            position: absolute;
            top: 50%;
            left: 50%;
            width: 400px;
            height: 400px;
            margin-top: -200px;
            margin-left: -200px;
            border-radius: 2px;
            box-shadow: 4px 8px 16px 0 rgba(0, 0, 0, 0.1);
            overflow: hidden;
            background: linear-gradient(to top right, darkmagenta 0%, hotpink 100%);
            color: #333;
            font-family: "Open Sans", Helvetica, sans-serif;
        }

        .center {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 300px;
            height: 260px;
            border-radius: 3px;
            box-shadow: 8px 10px 15px 0 rgba(0, 0, 0, 0.2);
            background: #fff;
            display: flex;
            align-items: center;
            justify-content: space-evenly;
            flex-direction: column;
        }

        .title {
            width: 100%;
            height: 50px;
            border-bottom: 1px solid #999;
            text-align: center;
        }

        h1 {
            font-size: 16px;
            font-weight: 300;
            color: #666;
        }

        .dropzone {
            width: 100px;
            height: 80px;
            border: 1px dashed #999;
            border-radius: 3px;
            text-align: center;
        }

        .upload-icon {
            margin: 25px 2px 2px 2px;
        }

        .upload-input {
            position: relative;
            top: -62px;
            left: 0;
            width: 100%;
            height: 100%;
            opacity: 0;
        }

        .btn {
            display: block;
            width: 140px;
            height: 40px;
            background: darkmagenta;
            color: #fff;
            border-radius: 3px;
            border: 0;
            box-shadow: 0 3px 0 0 hotpink;
            transition: all 0.3s ease-in-out;
            font-size: 14px;
        }

            .btn:hover {
                background: rebeccapurple;
                box-shadow: 0 3px 0 0 deeppink;
            }

        .custom-file-upload {
            border: 1px solid #ccc;
            display: inline-block;
            padding: 6px 12px;
            cursor: pointer;
        }

        input[type="file"] {
            z-index: -1;
            position: absolute;
            opacity: 0;
        }

        input:focus + label {
            outline: 2px solid;
        }
    </style>
    <script>

        $(document).ready(function () {
            $('input[type="file"]').change(function (e) {
                var fileName = e.target.files[0].name;
                alert('The file "' + fileName + '" has been selected.');
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
    </form>

    <div class="frame">
        <div class="center">
            <div class="title">
                <h1>Drop file to upload</h1>
            </div>
            <div class="dropzone">
                <img src="http://100dayscss.com/codepen/upload.svg" class="upload-icon" />
                <input type="file" id="" class="upload-input" />

            </div>
        </div>
    </div>




</body>
</html>
