CREATE TRIGGER upd_qianyg_�γ�  ON  qianyg_�γ�
FOR  INSERT,UPDATE
AS
    IF(  SELECT  qyg_ѧ��  FROM  INSERTED)  < 0  
    ROLLBACK  TRANSACTION

