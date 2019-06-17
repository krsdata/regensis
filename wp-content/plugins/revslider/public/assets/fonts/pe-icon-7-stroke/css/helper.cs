
/* HELPER CLASS 
 * -------------------------- */

/* FA based classes */

/*! Modified from font-awesome helper CSS classes - PIXEDEN
 *  Font Awesome 4.0.3 by @davegandy - http://fontawesome.io - @fontawesome
 *  License - http://fontawesome.io/license (CSS: MIT License)
 */

/* makes the font 33% larger relative to the icon container */
.pe-lg {
  font-size: 1.3333333333333333em;
  line-height: 0.75em;
  vertical-align: -15%;
}
.pe-2x {
  font-size: 2em;
}
.pe-3x {
  font-size: 3em;
}
.pe-4x {
  font-size: 4em;
}
.pe-5x {
  font-size: 5em;
}
.pe-fw {
  width: 1.2857142857142858em;
  text-align: center;
}
.pe-ul {
  padding-left: 0;
  margin-left: 2.142857142857143em;
  list-style-type: none;
}
.pe-ul > li {
  position: relative;
}
.pe-li {
  position: absolute;
  left: -2.142857142857143em;
  width: 2.142857142857143em;
  top: 0.14285714285714285em;
  text-align: center;
}
.pe-li.pe-lg {
  left: -1.8571428571428572em;
}
.pe-border {
  padding: .2em .25em .15em;
  border: solid 0.08em #eeeeee;
  border-radius: .1em;
}
.pull-right {
  float: right;
}
.pull-left {
  float: left;
}
.pe.pull-left {
  margin-right: .3em;
}
.pe.pull-right {
  margin-left: .3em;
}
.pe-spin {
  -webkit-animation: spin 2s infinite linear;
  -moz-animation: spin 2s infinite linear;
  -o-animation: spin 2s infinite linear;
  animation: spin 2s infinite linear;
}
@-moz-keyframes spin {
  0% {
    -moz-transform: rotate(0deg);
  }
  100% {
    -moz-transform: rotate(359deg);
  }
}
@-webkit-keyframes spin {
  0% {
    -webkit-transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(359deg);
  }
}
@-o-keyframes spin {
  0% {
    -o-transform: rotate(0deg);
  }
  100% {
    -o-transform: rotate(359deg);
  }
}
@-ms-keyframes spin {
  0% {
    -ms-transform: rotate(0deg);
  }
  100% {
    -ms-transform: rotate(359deg);
  }
}
@keyframes spin {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(359deg);
  }
}
.pe-rotate-90 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=1);
  -webkit-transform: rotate(90deg);
  -moz-transform: rotate(90deg);
  -ms-transform: rotate(90deg);
  -o-transform: rotate(90deg);
  transform: rotate(90deg);
}
.pe-rotate-180 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=2);
  -webkit-transform: rotate(180deg);
  -moz-transform: rotate(180deg);
  -ms-transform: rotate(180deg);
  -o-transform: rotate(180deg);
  transform: rotate(180deg);
}
.pe-rotate-270 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=3);
  -webkit-transform: rotate(270deg);
  -moz-transform: rotate(270deg);
  -ms-transform: rotate(270deg);
  -o-transform: rotate(270deg);
  transform: rotate(270deg);
}
.pe-flip-horizontal {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=0, mirror=1);
  -webkit-transform: scale(-1, 1);
  -moz-transform: scale(-1, 1);
  -ms-transform: scale(-1, 1);
  -o-transform: scale(-1, 1);
  transform: scale(-1, 1);
}
.pe-flip-vertical {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1);
  -webkit-transform: scale(1, -1);
  -moz-transform: scale(1, -1);
  -ms-transform: scale(1, -1);
  -o-transform: scale(1, -1);
  transform: scale(1, -1);
}
.pe-stack {
  position: relative;
  display: inline-block;
  width: 2em;
  height: 2em;
  line-height: 2em;
  vertical-align: middle;
}
.pe-stack-1x,
.pe-stack-2x {
  position: absolute;
  left: 0;
  width: 100%;
  text-align: center;
}
.pe-stack-1x {
  line-height: inherit;
}
.pe-stack-2x {
  font-size: 2em;
}
.pe-inverse {
  color: #ffffff;
}

/* Custom classes / mods - PIXEDEN */
.pe-va {
  vertical-align: middle;
}

.pe-border {
  border: solid 0.08em #eaeaea;
}

[class^="pe-7s-"], [class*=" pe-7s-"] {
  display: inline-block;
}