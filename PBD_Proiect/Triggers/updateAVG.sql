USE Students
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER updateAVG
   ON [dbo].[note] 
   AFTER INSERT AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @nrLegimInserted BIGINT
    
    SELECT @nrLegimInserted = insertedNote.nrLegim FROM inserted insertedNote

    UPDATE [dbo].[student]
    SET 
        medie_an1 = (SELECT AVG(note.nota_obtinuta) from [dbo].[note] WHERE (note.an_studiu = 1 AND student.nrLegim = note.nrLegim)),
        medie_an2 = (SELECT AVG(note.nota_obtinuta) FROM [dbo].[note] WHERE (note.an_studiu = 2 AND student.nrLegim = note.nrLegim)),
        medie_an3 = (SELECT AVG(note.nota_obtinuta) FROM [dbo].[note] WHERE (note.an_studiu = 3 AND student.nrLegim = note.nrLegim)),
        medie_generala = (SELECT AVG(myAverage) FROM (VALUES(student.medie_an1), (student.medie_an2), (student.medie_an3)) AS TblAverage(myAverage))
    WHERE student.nrLegim = @nrLegimInserted
END
GO