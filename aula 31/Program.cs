using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
< Form
“tags”
(identificadores)Name =”Nome do Formulário” – se lê HTML, C#
Id = “Nome do formulário” – se lê em java script
(Elemento de entrada) < Input >
Method =”forma de enviar os dados” (GET - as informações são enviadas na URL)
Post – as informações são enviadas ocultas
Action =”Resultado do form”> (Pagina ou método que vai processar os dados do formulário)

Site comandos html(w3schools)


< Body >
< Form >
  < Input Type =”text” Id =”nome” name =”nome”>
< Input Tyoe = “Text” Id = “CPF” name = “CPF”>
< Input Type = “Submit” Value = “Enviar”>
</ Form >



< !DOCTYPE html >
< html lang = "en" >
< head >
    < meta charset = "UTF-8" >
    < meta http - equiv = "X-UA-Compatible" content = "IE=edge" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < link href = "https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel = "stylesheet" integrity = "sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin = "anonymous" >
    < title > Document </ title >
</ head >
< body >
    < input method = "get" action = "receber.html" >
        < input > Nome </ label >
    < input Type = "text" Id = "nome" name = "nome" >
        < input > CPF </ label >
        < input Type = "Text" id = "CPF" name = "CPF" >
        < input Type = "Submit" value = "Enviar" >
        </ Form >
        </ body >
        </ html >


Exercícios
Montar um formulário html com os campos
•	Cpf
•	Nome
•	Rg
•	Data nasc.
•	Cep
•	Endereço
•	Número
•	Complemento
•	Bairro
•	Cidade



< !DOCTYPE html >
< html lang = "en" >
< head >
    < meta charset = "UTF-8" >
    < meta http - equiv = "X-UA-Compatible" content = "IE=edge" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Document </ title >
</ head >
< body >
    < div class="container">
    <form method = "get"action="receber.html">
        <div class="row">
            <div class="col-12">
                  <label for="nome">Nome</label>
                  <label> NOME</label>
                  <input type = "text" placeholder="Nome" id="NOME" name="NOME" class="form-control">
                    </div>
                   </div>
                    <div class="row">
                     <div class="col-12">

        }
}
}
