use SYSMY;

create table pessoa(
id int primary key identity(1,1),
nome varchar(100) not null,
RG varchar(15),
CPF varchar(15),
dataNascimento date);

create table cliente(
id int primary key identity(1,1),
nome varchar(100) not null,
RG varchar(15),
CPF varchar(15),
dataNascimento date,
pontuacaoCliente decimal default(0));

create table fornecedor(
id int primary key identity(1,1),
id_pessoa int,
CNPJ varchar(20),
RazaoSocial varchar(100),
TelefoneEmpresa varchar(100)
);



select * from cliente;

select f.id,f.id_pessoa,f.RazaoSocial,f.TelefoneEmpresa,f.CNPJ,p.nome from fornecedor as f 
join pessoa as p on p.id = f.id_pessoa

select * from funcionario;
insert into funcionario(nome,RG,CPF,data_nasc,salario,cargo,adm) values('Bruno Cavalcante',55458411,44577361809,'1996-07-07',3500,'Programador',0) 