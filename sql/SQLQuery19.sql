CREATE TRIGGER upd_qianyg_ѧ���ɼ�  ON  qianyg_ѧ���ɼ�
FOR  INSERT,UPDATE
AS
    IF(  SELECT  qyg_�ɼ�  FROM  INSERTED)  < 0 OR (SELECT  qyg_�ɼ�  FROM  INSERTED)  > 100
    ROLLBACK  TRANSACTION
