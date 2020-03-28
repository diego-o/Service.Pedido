create table Cliente (
	Id int identity not null,
	Nome varchar(100) not null,
	Cpf varchar(11) not null unique,
	Cep varchar(9) not null,
	Logradouro varchar(150) not null,
	Complemento varchar(100),
	Numero varchar(20) not null,
	Bairro varchar(100) not null,
	Cidade varchar(60) not null,
	Uf varchar(2) not null
  constraint pk_cliente primary key(Id)
)
go

create table Produto (
	Id int identity not null,
	Nome varchar(200) not null,
	Valor decimal(10,2) not null
  constraint pk_produto primary key(Id)
)
go

create table StatusPedido (
	Id int not null,
	Descricao varchar(50)
  constraint pk_statuspedido primary key(Id)
)
go

insert into StatusPedido values
(1, 'Solicitado'),
(2, 'Enviado Para Entrega'),
(3, 'Entregue'),
(4, 'Cancelado')
go

create table Pedido (
	Id int identity not null,
	IdCliente int not null,
	IdStatusPedido int not null,
	Total decimal(10,2) not null default 0,
  constraint pk_pedido primary key(Id),
  constraint fk_pedido_cliente foreign key(IdCliente) references Cliente(Id),
  constraint fk_pedido_statuspedido foreign key(IdStatusPedido) references StatusPedido(Id)
)
go

create table PedidoItem (
	IdPedido int not null,
	IdProduto int not null,
	Quantidade int not null
  constraint pk_pedidoitem primary key(IdPedido, IdProduto),
  constraint fk_pedidoitem_pedido foreign key(IdPedido) references Pedido(Id),
  constraint fk_pedidoitem_produto foreign key(IdProduto) references Produto(Id)
)
go