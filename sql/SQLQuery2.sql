create table qianyg_ѧ��  (
   qyg_ѧ��  char(12)  PRIMARY  KEY,
   qyg_����  char(20)  NOT  NULL,
   qyg_�Ա�  char(2)  check  (qyg_�Ա�  =  '��' or qyg_�Ա�  =  'Ů') NOT NULL,
   qyg_����  int  check(qyg_����  > 0 and qyg_����  < 200) NOT  NULL,
   qyg_��Դ���ڵ�  char(20)  NOT  NULL,
   qyg_����ѧ��  float,
   qyg_�༶���  char(6),
   constraint  FK_�༶_ѧ��  foreign  key  (qyg_�༶���) references qianyg_�༶
   )
