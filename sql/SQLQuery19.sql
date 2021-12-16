CREATE TRIGGER upd_qianyg_学生成绩  ON  qianyg_学生成绩
FOR  INSERT,UPDATE
AS
    IF(  SELECT  qyg_成绩  FROM  INSERTED)  < 0 OR (SELECT  qyg_成绩  FROM  INSERTED)  > 100
    ROLLBACK  TRANSACTION
