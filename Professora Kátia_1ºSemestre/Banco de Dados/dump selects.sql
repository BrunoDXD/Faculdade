describe tb01_militares;
describe tb02_patentes;
describe tb03_funcao;

select * From tb01_militares;
select * From tb01_militares where tb01_rm=3;
select * From tb01_militares where tb01_soldo>=10000;
select count(*) as quantidade From tb01_militares;
select sum(tb01_soldo) as soma From tb01_militares;