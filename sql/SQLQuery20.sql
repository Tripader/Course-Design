CREATE TRIGGER upd_qianyg_课程  ON  qianyg_课程
FOR  INSERT,UPDATE
AS
    IF(  SELECT  qyg_学分  FROM  INSERTED)  < 0  
    ROLLBACK  TRANSACTION

