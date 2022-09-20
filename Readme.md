Projeto TCC - Projeto Vicentina / 3°AMS Turma A
## Projeto feito em necessidade do Asilo Vila Vicentina e TCC ##
##########################################################


*? Commands Git ?*

$ clear $                          // Limpa o prompt

%% Novo Repositório Git/GitHub %%

$ git --version $                  // Verificar se o Git está instalado na máquina.
$ git init $                       // Inicializar um Repositório Git. 
$ git add .$                       // Adicionar/Mandar arquivos em Standing.
$ git status $                     // Verificar arquivos em Standing.
$ git commit -m "<Nome Commit>" $  // Fazer commit.
$ git brach -M "<Nome Branch>" $   // Alterar Nome da Branch Principal/default.
$ git remote add origin <Link do Repositório GitHub> $ // Conectar GitHub com Git.
$ git remote -v $                  // Visualizar o Repositório Conectado do GitHub
$ git push -u origin main $        // Enviar Arquivos do Standing ao GitHub.

%% Alternado/Ajustando Arquivos %%

$ git commit -m "<Nome Commit>" $  // Fazer commit.
$ git push origin main $           // Enviar Arquivos do Standing ao GitHub. ## Já ter feito o "First Commit"

%% Comandos para Nova Branch %%

$ git checkout -b "<Nome Branch>" $ // Criar Nova Branch e alterar imediatamente.
$ git branch "<Nome Branch>" $     // Criar Nova Branch.
$ git checkout <Nome Branch> $     // Alterar Branch.
$ git add .$                       // Adicionar/Mandar arquivos em Standing.
$ git commit -m "<Nome Commit>" $  // Fazer commit.
$ git push origin <Nome Branch> $  // Enviar Arquivos do Standing ao GitHub. ## De acordo com a Branch desejada.

%% Comandos para Merge %%
$ git merge --no-ff <Nome da Branch Principal> $       // Juntar duas branchs(ramificações) 

%% Clonando Repositório %%

$ git clone <Link do Repositório no GitHub> $ // Clonar Repositório do GitHub.
$ git pull $ // Atualizar.
