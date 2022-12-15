USE [Students]
GO
/****** Object:  StoredProcedure [dbo].[calculPromovabilitate]    Script Date: 12/15/2022 4:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[calculPromovabilitate]
	-- Add the parameters for the stored procedure here
	@disciplina varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	    SELECT AVG(case when [dbo].[note].nota_obtinuta >=5 then 100.0 else 0.0 end) as promovabilitate from [dbo].[note]
    WHERE disciplina = @disciplina
END
