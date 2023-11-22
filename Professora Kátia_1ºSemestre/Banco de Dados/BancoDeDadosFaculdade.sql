create database bd_aeroporto;
use bd_aeroporto;

create table tb01_companhia(tb01_id int not 
null auto_increment, tb01_nome varchar(255),
tb01_cnpj varchar(15), tb01_tel varchar(15),
primary key(tb01_id));

insert into tb01_companhia(tb01_id, tb01_nome, tb01_cnpj,
 tb01_tel) values(001, 'Gol', '23.076.864.0001-01', 
 '(11)987654567');
 
 alter table tb01_companhia modify tb01_cnpj varchar(20);
 
 create table tb02_aeroporto(tb02_id int not null 
 auto_increment, tb02_nome varchar(255), 
 tb02_cidade varchar(255), tb02_pais varchar(255),
 primary key(tb02_id));
 
 create table tb03_aeronave(tb03_id int not null 
 auto_increment, tb03_modelo varchar(255), tb03_fabricante
 varchar(255), tb03_capacidade int, primary key(tb03_id));
 
 
 create table tb04_voo(tb04_id int not
 null auto_increment, tb04_dt_decolagem
 date, tb04_hr_decolagem time, tb04_aero_decolagem
 int, tb04_dt_aterrissagem date, tb04_hr_aterrissagem
 time, tb04_aero_aterrissagem int, tb04_id_companhia int,
 tb04_id_aeronave int, primary key(tb04_id), foreign key
 (tb04_aero_decolagem) references tb02_aeroporto(tb02_id),
 foreign key(tb04_aero_aterrissagem) references 
 tb02_aeroporto(tb02_id),foreign key(tb04_id_companhia)
 references tb01_companhia(tb01_id),foreign key
 (tb04_id_aeronave) references tb03_aeronave(tb03_id));
 
 insert into tb02_aeroporto values(2, 'aeroporto Santos drumond',
 'Santos', 'Brasil');
 insert into tb03_aeronave values(100, 'boing 777', 'boing',
 300);
 insert into tb04_voo values(35, '2023-05-20', '10:00:00',
 1, '2023-05-20', '11:00:00', 2, 1, 100);
 select * from tb01_companhia;
 select * from tb02_aeroporto;
 select * from tb03_aeronave;
 select * from tb04_voo;
 
 update tb04_voo set tb04_dt_decolagem='2023-05-21', 
 tb04_dt_aterrissagem='2023-05-21' where tb04_id=2;
 
drop table tb01_companhia;
drop table tb02_aeroporto;
drop table tb03_aeronave;
drop table tb04_voo;
 
 
 