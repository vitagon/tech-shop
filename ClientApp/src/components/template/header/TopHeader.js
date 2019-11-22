import React, { Component } from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPhone, faMapMarkerAlt, faDollarSign } from '@fortawesome/free-solid-svg-icons';
import { faEnvelope, faUser } from '@fortawesome/free-regular-svg-icons';
import './TopHeader.css';

class TopHeader extends Component {
  render() {
    return (
      <>
        <div id="top-header">
          <div className="container">
            <div className="row">
              <ul className="header-links">
                <li><a href="#"><FontAwesomeIcon icon={faPhone} /> +021-95-51-84</a></li>
                <li><a href="#"><FontAwesomeIcon icon={faEnvelope} /> email@email.com</a></li>
                <li><a href="#"><FontAwesomeIcon icon={faMapMarkerAlt} /> 1734 Stonecoal Road</a></li>
              </ul>
              <ul className="header-links">
                <li><a href="#"><FontAwesomeIcon icon={faDollarSign} /> USD</a></li>
                <li><a href="#"><FontAwesomeIcon icon={faUser} /> My Account</a></li>
              </ul>
            </div>
          </div>
        </div>
      </>
    );
  }
};

export default TopHeader;
