IF OBJECT_ID('[dbo].[RPT_MOVIMIENTOS_AUX1]','P') IS NOT NULL
	DROP PROCEDURE [dbo].[RPT_MOVIMIENTOS_AUX1]
GO


CREATE   PROCEDURE [dbo].[RPT_MOVIMIENTOS_AUX1]
	@CLIENTE_ID		VARCHAR(15)	OUTPUT,
	@PRODUCTO_ID	VARCHAR(30)		OUTPUT,
	@NRO_PALLET		VARCHAR(100)	OUTPUT,
	@NRO_PARTIDA	VARCHAR(50)		OUTPUT,
	@FECHA_VTO		VARCHAR(8)		OUTPUT,	--ANSI
	@F_DESDE		VARCHAR(8)			OUTPUT,	--ANSI
	@F_HASTA		VARCHAR(8)			OUTPUT,	--ANSI
	@NRO_LOTE		VARCHAR(50)		OUTPUT,
	@PROP2			VARCHAR(100)		OUTPUT,
	@PROP3			VARCHAR(100)		OUTPUT,
	@USUARIO		VARCHAR(20) 		OUTPUT,
	@COD_PEDIDO	VARCHAR(30)		OUTPUT,
	@COD_VIAJE	VARCHAR(100)		OUTPUT
AS
BEGIN



    DECLARE @PICK			NUMERIC(20,0)
	DECLARE @SERIE			VARCHAR(100)
	DECLARE @PICK_ANT			NUMERIC(20,0)
	DECLARE @SERIE_ACUM			VARCHAR(3000)
	----------------------------------------------------------------------


	DECLARE CUR CURSOR FOR 
		SELECT SP.PICKING_ID, SP.NRO_SERIE FROM SERIEPICKING SP (NOLOCK)
			INNER JOIN PICKING P						(NOLOCK) ON (P.PICKING_ID = SP.PICKING_ID)
			INNER JOIN vDET_DOCUMENTO DD			(NOLOCK) ON(P.DOCUMENTO_ID=DD.DOCUMENTO_ID AND P.NRO_LINEA=DD.NRO_LINEA)
			INNER JOIN vDOCUMENTO D 				(NOLOCK) ON(DD.DOCUMENTO_ID=D.DOCUMENTO_ID)
			INNER JOIN TIPO_COMPROBANTE TC 			(NOLOCK) ON(D.TIPO_COMPROBANTE_ID=TC.TIPO_COMPROBANTE_ID)
			INNER JOIN CLIENTE C					(NOLOCK) ON(C.CLIENTE_ID=P.CLIENTE_ID)
			LEFT JOIN SYS_USUARIO SU				(NOLOCK) ON(P.USUARIO_CONTROL_FAC=SU.USUARIO_ID)
			LEFT JOIN SUCURSAL	S					(NOLOCK) ON(S.CLIENTE_ID=D.CLIENTE_ID AND S.SUCURSAL_ID=D.SUCURSAL_DESTINO)
			WHERE	((@NRO_PALLET IS NULL)OR(P.PROP1=@NRO_PALLET))
			AND	((@F_DESDE IS NULL)OR(D.FECHA_ALTA_GTW BETWEEN @F_DESDE AND DATEADD(DD,1,@F_HASTA)))
			AND P.FACTURADO='1'
			AND 16 In (Select Tipo_Auditoria_Id from #TEMP_CRITERIOS_RPT)
			AND((@CLIENTE_ID IS NULL) OR (P.CLIENTE_ID=@CLIENTE_ID))
			AND((@PRODUCTO_ID IS NULL) OR (P.PRODUCTO_ID=@PRODUCTO_ID))
			AND((@NRO_PARTIDA IS NULL) OR (DD.NRO_PARTIDA=@NRO_PARTIDA))
			AND((@FECHA_VTO IS NULL) OR (DD.FECHA_VENCIMIENTO=@FECHA_VTO))
			AND((@USUARIO IS NULL) OR (P.USUARIO_CONTROL_FAC=@USUARIO))
			AND((@NRO_LOTE IS NULL) OR (DD.NRO_LOTE=@NRO_LOTE))
			AND((@PROP2 IS NULL) OR (DD.PROP2=@PROP2))
			AND((@PROP3 IS NULL) OR (DD.PROP3=@PROP3))
			AND((@COD_PEDIDO IS NULL) OR(D.NRO_REMITO LIKE  '%'+ @COD_PEDIDO +  '%'))
			AND((@COD_VIAJE IS NULL) OR(D.NRO_DESPACHO_IMPORTACION LIKE '%' + @COD_VIAJE + '%'))
				
	--create table tmpSeriesPicking(PICKING_ID NUMERIC(20,0), SERIES varchar(3000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL)

	TRUNCATE TABLE tmpSeriesPicking
		
	SET @SERIE_ACUM ='' 
	OPEN CUR 
	FETCH NEXT FROM CUR INTO @PICK, @SERIE
	SET @PICK_ANT = @PICK
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @PICK_ANT <> @PICK
			BEGIN
				INSERT INTO tmpSeriesPicking VALUES (@PICK_ANT, @SERIE_ACUM)
				SET @SERIE_ACUM = '' 
			END
		IF @SERIE_ACUM = '' 
			BEGIN
				SET @SERIE_ACUM = @SERIE
				SET @PICK_ANT = @PICK
			END
		ELSE
			BEGIN
				SET @SERIE_ACUM = @SERIE_ACUM + '; ' + @SERIE
				SET @PICK_ANT = @PICK	
			END
		FETCH NEXT FROM CUR INTO @PICK, @SERIE
	END
	IF @SERIE_ACUM <> ''
		INSERT INTO tmpSeriesPicking VALUES (@PICK_ANT, @SERIE_ACUM)
	CLOSE CUR
	DEALLOCATE CUR
	
END

