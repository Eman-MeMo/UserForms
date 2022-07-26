/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     5/27/2022 10:51:19 PM */

/*==============================================================*/




/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/


create table CATEGORY 
(
	CATEGORYID        numeric(10)    identity(1,1)  Primary Key,
   CATEGORYNAME         char(20)                       not null,
   NUMOFPRODUCTS        numeric(5)                     not null,

   
   
);

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT 
(
   PRODUCTID            numeric(10)                    not null,
   CATEGORYID           numeric(10)                    not null,
   PRODUCTPRICE         decimal(9)                     not null,
   PRODUCTNAME          varchar(20)                    not null,
   QUANTITY             numeric(9)                     not null,
   constraint PK_PRODUCT primary key (PRODUCTID),
   constraint FK_PRODUCT_BELONGS_T_CATEGORY foreign key (CATEGORYID)
      references CATEGORY (CATEGORYID)

);

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN 
(
   ADMINNAME            char(30)                       not null,
   PASSWWORD            char(11)                       not null,
   constraint PK_ADMIN primary key (ADMINNAME, PASSWWORD)
);

/*==============================================================*/
/* Table: ACCESS                                                */
/*==============================================================*/
create table ACCESS 
(
   ADMINNAME            char(30)                       not null,
   PASSWWORD            char(11)                       not null,
   PRODUCTID            numeric(10)                    not null,
   constraint PK_ACCESS primary key (ADMINNAME, PASSWWORD, PRODUCTID),
   constraint FK_ACCESS_RELATIONS_PRODUCT foreign key (PRODUCTID)
      references PRODUCT (PRODUCTID),
   constraint FK_ACCESS_RELATIONS_ADMIN foreign key (ADMINNAME, PASSWWORD)
      references ADMIN (ADMINNAME, PASSWWORD)
);

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER 
(
   CUSTOMERNAME         char(30)                       not null,
   CUSTOMERADDRESS      char(20)                       not null,
   PASSWORD             char(11)                       not null,
   SCORE                numeric(4)                     null,
   TELEPHONE_NUM        numeric(11)                    not null,
   constraint PK_CUSTOMER primary key (CUSTOMERNAME)
);

/*==============================================================*/
/* Table: ACCESS_TO                                             */
/*==============================================================*/
create table ACCESS_TO 
(
   ADMINNAME            char(30)                       not null,
   PASSWWORD            char(11)                       not null,
   CUSTOMERNAME         char(30)                       not null,
   constraint PK_ACCESS_TO primary key (ADMINNAME, PASSWWORD, CUSTOMERNAME),
   constraint FK_ACCESS_T_RELATIONS_CUSTOMER foreign key (CUSTOMERNAME)
      references CUSTOMER (CUSTOMERNAME),
   constraint FK_ACCESS_T_RELATIONS_ADMIN foreign key (ADMINNAME, PASSWWORD)
      references ADMIN (ADMINNAME, PASSWWORD)
);

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER 
(
   SUPPLIERID           numeric(10)                    not null,
   SUPPLIERNAME         char(20)                       not null,
   constraint PK_SUPPLIER primary key (SUPPLIERID)
);

/*==============================================================*/
/* Table: SUPPLIED_BY                                           */
/*==============================================================*/
create table SUPPLIED_BY 
(
   PRODUCTID            numeric(10)                    not null,
   SUPPLIERID           numeric(10)                    not null,
   constraint PK_SUPPLIED_BY primary key (PRODUCTID, SUPPLIERID),
   constraint FK_SUPPLIED_RELATIONS_SUPPLIER foreign key (SUPPLIERID)
      references SUPPLIER (SUPPLIERID),
   constraint FK_SUPPLIED_RELATIONS_PRODUCT foreign key (PRODUCTID)
      references PRODUCT (PRODUCTID)

);

/*==============================================================*/
/* Table: PURCHASE                                           */
/*==============================================================*/

create table PURCHASE 
(
   CUSTOMERNAME         char(30)                       not null,
   PRODUCTID            numeric(10)                    not null,
   TDATE                date                           not null,
   constraint PK_TRANSACTION primary key (CUSTOMERNAME, PRODUCTID,TDATE),
   constraint FK_TRANSACT_RELATIONS_CUSTOMER foreign key (CUSTOMERNAME)
      references CUSTOMER (CUSTOMERNAME),
	ADD CONSTRAINT FK_PRODUCT foreign key (PRODUCTID)
      references PRODUCT (PRODUCTID)
);