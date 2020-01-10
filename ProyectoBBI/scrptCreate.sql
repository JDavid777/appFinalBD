
create table SINDICALISTA 
(
   SINID                numeric                        not null,
   SINNOMBRE            varchar(50)                    not null,
   SINAPELLIDO          varchar(50)                    not null,
   SINESTADO            varchar(30)                    not null,
   SINGENERO           varchar(3)                     not null,
   constraint PK_SINDICALISTA primary key (SINID),
   constraint CKC_GENERO CHECK (SINGENERO IN ('f','m'))
);



create table EMPRESA 
(
   EMPNIT               numeric                        not null,
   EMPNOMBRE            varchar(30)                   not  null,
   constraint PK_EMPRESA primary key (EMPNIT),
   constraint CKC_EMPNIT CHECK(EMPNIT>0)
);
create table SINDICATO 
(
   NOREGISTROSIND       numeric                        not null,
   EMPNIT               numeric                        not null,
   NOMBRE               varchar(50)                   not  null,
   FECHAFUNDACION       date                           not null,
   constraint PK_SINDICATO primary key (NOREGISTROSIND),
   CONSTRAINT FK_sinEmp foreign key (empnit) references empresa(empnit)
);
create table AGREMIA 
(
   NOREGISTROSIND       numeric                        not null,
   SINID                numeric                        not null,
   FECHAINICIO          date                           not null,
   FECHAFIN             date                           not null,
   constraint PK_AGREMIA primary key clustered (NOREGISTROSIND, SINID),
   constraint FK_sindAgr foreign key (sinid)references SINDICALISTA (sinid),
   constraint FK_sinAgr foreign key (noregistrosind)references SINDICATO(noregistrosind)
);
