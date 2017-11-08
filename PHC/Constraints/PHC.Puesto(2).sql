CREATE TABLE [PHC].[Puesto] (
    [idPuesto]          INT            IDENTITY (1, 1) NOT NULL,
    [nombre]            NVARCHAR (100) NOT NULL,
    [descripcion]       NVARCHAR (200) NULL,
    [esResponsableDpto] BIT            NULL,
    [idDepartamento] INT NULL, 
    [idNivel] INT NULL, 
    CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED ([idPuesto] ASC),
	CONSTRAINT [FK_Puesto_idDepartamento] FOREIGN KEY (idDepartamento) REFERENCES PHC.Departamento (idDepartamento),
	CONSTRAINT [FK_Puesto_idNivel] FOREIGN KEY (idNivel) REFERENCES PHC.Nivel (idNivel)
);

