USE [GEDPES_OI_PRD]
GO
/****** Object:  StoredProcedure [dbo].[GED_PROC_CodigosBarras]    Script Date: 07/17/2014 23:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    ALTER PROCEDURE [dbo].[GED_PROC_CodigosBarras]
    	@TIPO INT, @SUB INT,@CODIGO VARCHAR(10)
    AS
    BEGIN
    	-- SET NOCOUNT ON ADDED TO PREVENT EXTRA RESULT SETS FROM
    	-- INTERFERING WITH SELECT STATEMENTS.
    	SET NOCOUNT ON;
    	
    	--CRIANDO ESTRUTURA DA TABELA PRINCIPAL
		SELECT * INTO #TB_MASTER FROM (
    		SELECT	A.TPD_CODIGOBARRA,
            TPD_DESCRICAO,
            TPD_TEMPOVALIDADE,
            A.TPD_IDDIVISAO,
            A.TPD_IDTIPODOCUMENTO,
            NULL STD_IDSUBTIPOSDOCUMENTOS,
            0 STD_FLAGVENCIMENTOMANUAL,
            0 STD_MESVENCIMENTOANUAL 
            FROM GEDTIPOSDOCUMENTOS A 
            WHERE	TPD_IDTIPODOCUMENTO > 0
		UNION ALL
            SELECT	B.STD_CODIGOBARRA AS TPD_CODIGOBARRA,
            B.STD_DESCRICAO AS TPD_DESCRICAO,
            B.STD_TEMPOVALIDADE AS TPD_TEMPOVALIDADE,
            D.TPD_IDDIVISAO,
            D.TPD_IDTIPODOCUMENTO,
            B.STD_IDSUBTIPOSDOCUMENTOS,
            B.STD_FLAGVENCIMENTOMANUAL,
            B.STD_MESVENCIMENTOANUAL  
            FROM GEDSUBTIPOSDOCUMENTOS B
            JOIN GEDTIPOSDOCUMENTOS D ON B.STD_IDTIPOSDOCUMENTOS = D.TPD_IDTIPODOCUMENTO
            WHERE	STD_IDSUBTIPOSDOCUMENTOS > 0
            )BARCODE
                  JOIN GEDDIVISOES DV ON BARCODE.TPD_IDDIVISAO = DV.DIV_IDDIVISAO 
                  

        

        IF (@TIPO =1 AND @SUB = 1)
    	  GOTO GOTOALL;
        ELSE
        IF (@TIPO = 1)
        BEGIN
    		DELETE FROM #TB_MASTER
    			WHERE NOT  STD_IDSUBTIPOSDOCUMENTOS IS NULL
        END  ELSE IF (@SUB = 1)
        BEGIN
    		DELETE FROM #TB_MASTER
    			WHERE STD_IDSUBTIPOSDOCUMENTOS IS NULL
        END 
        
        GOTOALL:
        
        IF (@CODIGO = '')
          SELECT *,
          CASE WHEN TPD_TEMPOVALIDADE > 0 OR 
    		STD_MESVENCIMENTOANUAL > 0 THEN 1 ELSE 0 
    		END AS REQUERDATAINICIOVALIDADE,
    		cast(null as datetime) as StartDateValidity,
    		cast(null as datetime) as DateValidity
          FROM #TB_MASTER
        ELSE
        BEGIN
          SELECT *,
          CASE WHEN TPD_TEMPOVALIDADE > 0 OR 
    		STD_MESVENCIMENTOANUAL > 0 THEN 1 ELSE 0 
    		END AS REQUERDATAINICIOVALIDADE,
    		cast(null as datetime) as StartDateValidity,
    		cast(null as datetime) as DateValidity
          FROM #TB_MASTER
          WHERE TPD_CODIGOBARRA = @CODIGO
        END;  
        
       
        DROP TABLE #TB_MASTER
        END
