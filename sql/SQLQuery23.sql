CREATE PROCEDURE InsertResult
@ѧ��  char(20)
AS
   SET  NOCOUNT  ON
   DECLARE  @nCount  int  SET  @nCount=0
   SELECT  @nCount=COUNT(qyg_ѧ��)  FROM  qianyg_ѧ�� WHERE  qianyg_ѧ��.qyg_ѧ��=@ѧ��
   IF  @nCount<1
   BEGIN
     PRINT 'ѧ��������Ϣ���в����ڴ�ѧ�ţ��������������'
     RETURN
   END
