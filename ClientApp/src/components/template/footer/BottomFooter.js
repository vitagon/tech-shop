import React, { Component } from 'react';
import { connect } from 'react-redux';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faCcVisa, faCcPaypal, faCcMastercard, faCcDiscover, faCcAmex } from '@fortawesome/free-brands-svg-icons';
import { faCreditCard } from '@fortawesome/free-solid-svg-icons';
import { faHeart } from '@fortawesome/free-regular-svg-icons';
import './BottomFooter.css';


class BottomFooter extends Component {

  getCurrentYear() {
    return new Date().getFullYear();
  }

  render() {
    return (
      <div id="bottom-footer" className="section">
        <div className="container">
					<div className="row">
            <div className="col-md-12 text-center">
              <ul className="footer-payments">
                <li><a href="#"><FontAwesomeIcon icon={faCcVisa} /></a></li>
                <li><a href="#"><FontAwesomeIcon icon={faCreditCard} /></a></li>
                <li><a href="#"><FontAwesomeIcon icon={faCcPaypal} /></a></li>
                <li><a href="#"><FontAwesomeIcon icon={faCcMastercard} /></a></li>
                <li><a href="#"><FontAwesomeIcon icon={faCcDiscover} /></a></li>
                <li><a href="#"><FontAwesomeIcon icon={faCcAmex} /></a></li>
              </ul>
              <span className="copyright">
                Copyright &copy;{this.getCurrentYear()} All rights reserved | This template is made with <FontAwesomeIcon icon={faHeart} /> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
							</span>
            </div>
          </div>
				</div>
			</div>
    )
  }
}

export default connect(null, null)(BottomFooter);