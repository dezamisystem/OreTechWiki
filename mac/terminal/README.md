# Terminal Tips

ターミナルに関する情報

## 目次

[zsh設定](#zsh設定)

[vim設定](#vim設定)

## zsh設定

- ```.zshrc```ファイル作成

```sh
$ cd ~
$ touch .zshrc
$ vim .zshrc
```

記述例

```sh
# color
autoload -Uz colors
colors

# prompt format
PROMPT="%F{cyan}[%m] %. $%F{reset}"

# ls colors
export CLICOLOR=1
export LSCOLORS=CxGxcxdxCxegedabagacad

# ls alias
alias ls="ls -FG"
alias ll="ls -alFG"

# for history
export HISTSIZE=2000
export SAVEHIST=2000
setopt hist_ignore_dups
setopt EXTENDED_HISTORY
function history-all { history -E 1 }

# for brew
export PATH="/usr/local/sbin:$PATH"

# for rbenv
[[ -d ~/.rbenv  ]] && \
  export PATH=${HOME}/.rbenv/bin:${PATH} && \
  eval "$(rbenv init -)"
```

- ターミナルの環境設定から一般タブを選択

- ```開くシェル```で```コマンド（完全パス）```を選んで以下を入力

```sh
/bin/zsh
```

- 新規ウィンドウ開くと反映されている

## vim設定

- ```.vimrc```ファイル作成

```sh
$ cd ~
$ touch .vimrc
$ vim .vimrc
```

記述例

```sh
:syntax on

set virtualedit=onemore

set laststatus=2

set expandtab

set shiftwidth=4

set tabstop=4
```

- ```vim```を閉じて再度開くと反映されている

---

Copyright (C) 2020 東亜プリン秘密研究所. All rights reserved.
