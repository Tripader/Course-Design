CREATE PROCEDURE �γ̷���
@�γ̱��  char(20)
AS
   SET  NOCOUNT  ON
   DECLARE  @nCount  int  SET  @nCount=0
   SELECT  @nCount=COUNT(qyg_�γ̱��)  FROM  qianyg_�γ� WHERE  qianyg_�γ�.qyg_�γ̱��=@�γ̱��
   IF  @nCount<1
   BEGIN
     PRINT '�γ̻�����Ϣ���в����ڴ�ѧ�ţ��������������'
     RETURN
   END
