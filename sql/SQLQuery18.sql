CREATE TRIGGER upd_qianyg_�γ����� ON  qianyg_�γ�
FOR  INSERT,UPDATE
AS
    IF(SELECT qyg_�γ����� FROM INSERTED)!='����' and (SELECT qyg_�γ����� FROM INSERTED)!='����'
    ROLLBACK  TRANSACTION
