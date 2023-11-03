# report1
# GIT 사용법
------------
##배경
로컬 저장소(local)와 원격 저장소(remote)
 - git 저장소는 자신의 컴퓨터인 로컬 저장소와 서버에 있는 원격 저장소로 나뉜다. 
 - local에서 작업한 것은 remote로 push해줘야만 변경사항이 서버에 반영된다.
add, commit, push
 - 자신이 작업한 내용을 remote 저장소에 반영하기 위해서는, 변경사항을 추가하고(add), local에 저장하고(commit), remote에 업로드(push) 해야한다
 branch
 - 여러 개발자들이 공동으로 작업할 수 있게 기본 master branch에서 새로운 가지를 만들어 독립된 공간에서 작업을 수행할 수 있다. 이 때 주기적으로 변경사항을 합치는 것이 필요하다. 
 pull
 - remote에 있는 내용을 local에 받는 과정이다. 이때 현재 자신의 branch가 어디인지 확인을 잘 하고 pull하도록 한다. 만약 자신의 local에 변경사항이 있다면 pull할 시 에러가 나므로 add, commit을 진행한 후 pull하거나 stash하여 자신의 변경사항을 다른곳에 저장한 후 pull하도록 한다. 
 remote 저장소에 변경된 사항이 있을 수 있기에(여러명이서 작업시) 무조건 파일을 건들기 전에 pull하도록 한다. 안그러면 conflict이 일어나 수동으로 고쳐야한다.
기본 흐름
 - github 공간 만들기(clone, init) => 파일 작성 => 파일의 변경사항 임시저장(add) => local에 저장(commit) => remote에 업데이트(push) => 로컬 업데이트(pull) => add => commit => push ==> pull...(반복)
 
-------------
##명령어
```	
git clone: 깃허브에서 project를 만든 후 git clone하여 local에도 작업공간을 만든다. 
git init: 깃허브에서 project를 만들어 clone하지 않고 컴퓨터에서 작업을 먼저 시작했을 때 저장소를 생성한다. 
git pull: 자신의 local에 변경사항이 있다면 pull할 시 에러가 나므로 add, commit을 진행한 후 pull하거나 stash하여 자신의 변경사항을 다른곳에 저장한 후 pull한다.
git branch: 현재 branch(*표시 되어있는) 및 local branch 확인 기본 master branch에서 새로운 가지를 만들어 독립된 공간에서 작업을 수행
git add: 변경사항 모두( . )임시저장
git commit -m: commit 하여 local 저장소에 반영
git push: remote 저장소에 변경사항 반영
git checkout: 해당 브랜치로 이동
git checkout-b:  해당 브랜치 만들고 이동
```
