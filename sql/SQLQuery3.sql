create table qianyg_��ʦ  (
   qyg_��ʦ���  char(20)  PRIMARY  KEY,
   qyg_����  char(20)  NOT  NULL,
   qyg_�Ա�  char(2)  check  (qyg_�Ա�  =  '��' or qyg_�Ա�  =  'Ů') NOT NULL,
   qyg_����  int  check(qyg_����  > 0 and qyg_����  < 200) NOT  NULL,
   qyg_ְ��  char(20)  NOT  NULL,
   qyg_��ϵ�绰  char(6) NOT  NULL
   )
