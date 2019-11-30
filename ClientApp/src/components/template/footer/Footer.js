import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import TopFooter from './TopFooter';
import BottomFooter from './BottomFooter';
//import './Curtain.css';


class Footer extends Component {
  render() {
    return (
      <footer id="footer">
        <TopFooter></TopFooter>
        <BottomFooter></BottomFooter>
      </footer>
    )
  }
}

const mapStateToProps = (state) => ({
  //showSideNavPanel: state.navPanelReducer.showSideNavPanel
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  //hideSideNavPanel: () => (dispatch) => dispatch({ type: HIDE_SIDE_NAV_PANEL, payload: false })
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Footer);